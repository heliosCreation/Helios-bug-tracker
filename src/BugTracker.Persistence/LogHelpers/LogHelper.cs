using BugTracker.Application.Model.Auditing;
using BugTracker.Domain.Common;
using BugTracker.Domain.Entities;
using BugTracker.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Persistence.LogHelpers
{
    public class LogHelper
    {
        private readonly ApplicationDbContext _dbContext;

        public LogHelper(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task OnBeforeSaveChangesAsync(string userId)
        {
            _dbContext.ChangeTracker.DetectChanges();
            var auditEntries = new List<AuditEntry>();

            await MapEntries(auditEntries, userId);

            foreach (var auditEntry in auditEntries)
            {
                var auditLog = auditEntry.ToAudit();
                await _dbContext.AuditLogs.AddAsync(auditLog);
            }
        }
        private async Task MapEntries(List<AuditEntry> auditEntries, string userId)
        {
            var entries = _dbContext.ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                if (entry.Entity is Audit || entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                    continue;

                var auditEntry = new AuditEntry(entry);
                auditEntry.TableName = entry.Entity.GetType().Name;
                auditEntry.UserId = userId;
                auditEntries.Add(auditEntry);
                await MapPropertiesToEntryValue(entries, entry, auditEntry);

            }

        }
        private async Task MapPropertiesToEntryValue(IEnumerable<EntityEntry> entries, EntityEntry entry, AuditEntry auditEntry)
        {
            foreach (var property in entry.Properties)
            {
                var current = property.CurrentValue;
                var old = property.OriginalValue;

                if (property.Metadata.IsPrimaryKey())
                {
                    auditEntry.KeyValues[property.Metadata.Name] = current;
                }

                if (property.Metadata.IsForeignKey())
                {
                    current = await MapFKToAuditEntryValue(entries, property, auditEntry, current);
                    old = await MapFKToAuditEntryValue(entries, property, auditEntry, old);
                }
                await AssignValuesBasedOnEntryState(auditEntry, current, old, property, entry);
            }

        }

        private async Task<object> MapFKToAuditEntryValue(IEnumerable<EntityEntry> entries, PropertyEntry property, AuditEntry auditEntry, object current)
        {
            var name = property.Metadata.Name.ToLower();

            if (name.Contains("priority"))
            {
                current = await _dbContext.Priority.AsNoTracking().Where(p => p.Id == (Guid)current).Select(p => p.Name).FirstOrDefaultAsync();
            }
            else if (name.Contains("type"))
            {
                current = await _dbContext.Type.AsNoTracking().Where(p => p.Id == (Guid)current).Select(p => p.Name).FirstOrDefaultAsync();
            }
            else if (name.Contains("status"))
            {
                current = await _dbContext.Status.AsNoTracking().Where(p => p.Id == (Guid)current).Select(p => p.Name).FirstOrDefaultAsync();
            }
            else if (name.Contains("ticket"))
            {
                current = await _dbContext.Tickets.AsNoTracking().Where(t => t.Id == (Guid)current).Select(p => p.Name).FirstOrDefaultAsync();
            }
            else if (name.Contains("project"))
            {
                current = await _dbContext.Projects.AsNoTracking().Where(p => p.Id == (Guid)current).Select(p => p.Name).FirstOrDefaultAsync();
                if (current == null)
                {
                    current = entries.ToList()[0].Property("Name").CurrentValue;
                }
            }
            else if (name.Contains("user"))
            {
                current = await _dbContext.Users.AsNoTracking().Where(u => u.Id == (string)property.CurrentValue).Select(u => u.UserName).FirstOrDefaultAsync();
            }
            else if (name.Contains("role"))
            {
                current = await _dbContext.Roles.AsNoTracking().Where(r => r.Id == (string)current).Select(p => p.Name).FirstOrDefaultAsync();
            }
            return current;
        }

        private async Task AssignValuesBasedOnEntryState(AuditEntry auditEntry, object current, object old, PropertyEntry property, EntityEntry entry)
        {
            var blackList = new List<string> { "CreatedBy", "LastModifiedBy", "CreatedDate", "LastModifiedDate", "ApplicationUserId" };
            if (blackList.Contains(property.Metadata.Name))
            {
                return;
            }
            switch (entry.State)
            {
                case EntityState.Added:
                    auditEntry.AuditType = Application.Enums.AuditType.Create;
                    if (auditEntry.TableName == "ApplicationUser")
                    {
                        auditEntry.NewValues.Clear();
                        auditEntry.NewValues["User"] = ((ApplicationUser)entry.Entity).UserName;
                    }

                    else
                    {
                        if (auditEntry.TableName == "TicketsTeamMembers")
                        {
                            var pid = ((TicketsTeamMembers)entry.Entity).Ticket.ProjectId;
                            auditEntry.NewValues["Project"] = await _dbContext.Projects.AsNoTracking().Where(p => p.Id == pid).Select(p => p.Name).FirstOrDefaultAsync();

                        }
                        else if(auditEntry.TableName == "Comment")
                        {
                            var tid = ((Comment)entry.Entity).TicketId;

                            auditEntry.NewValues["Project"] = await _dbContext.Tickets.AsNoTracking().Where(t => t.Id == tid).Select(t => t.Project.Name).FirstOrDefaultAsync();
                        }
                        auditEntry.NewValues[property.Metadata.Name] = current;
                    }

                    break;
                case EntityState.Deleted:
                    auditEntry.AuditType = Application.Enums.AuditType.Delete;
                    if (auditEntry.TableName == "ApplicationUser")
                    {
                        auditEntry.OldValues.Clear();
                        auditEntry.OldValues["User"] = ((ApplicationUser)entry.Entity).UserName;
                    }
                    else
                    {
                        if (auditEntry.TableName == "TicketsTeamMembers")
                        {
                            var pid = ((TicketsTeamMembers)entry.Entity).Ticket.ProjectId;
                            auditEntry.OldValues["Project"] = await _dbContext.Projects.AsNoTracking().Where(p => p.Id == pid).Select(p => p.Name).FirstOrDefaultAsync();

                        }
                        auditEntry.OldValues[property.Metadata.Name] = current;
                    }
                    break;
                case EntityState.Modified:
                    if (property.IsModified)
                    {

                        auditEntry.ChangedColumns.Add(property.Metadata.Name);
                        auditEntry.AuditType = Application.Enums.AuditType.Update;
                        auditEntry.OldValues[property.Metadata.Name] = old;
                        auditEntry.NewValues[property.Metadata.Name] = current;
                        if (auditEntry.TableName == "ApplicationUser")
                        {
                            if (ManagePasswordUpdate(auditEntry, entry))
                            {
                                break;
                            }
                            if (ManageEmailConfirmation(auditEntry, entry))
                            {
                                break;
                            }
                            auditEntry.NewValues["User"] = ((ApplicationUser)entry.Entity).UserName;
                            auditEntry.OldValues["User"] = ((ApplicationUser)entry.Entity).UserName;
                        }

                        if (auditEntry.TableName == "Ticket")
                        {
                            auditEntry.NewValues["Name"] = ((Ticket)entry.Entity).Name;
                            auditEntry.OldValues["Name"] = ((Ticket)entry.Entity).Name;

                            var projectName = await _dbContext.Projects.Where(p => p.Id == ((Ticket)entry.Entity).ProjectId).Select(p => p.Name).FirstOrDefaultAsync();
                            auditEntry.NewValues["ProjectId"] = projectName;
                            auditEntry.OldValues["ProjectId"] = projectName;

                        }
                    }
                    break;
            }

        }
    

        private bool ManagePasswordUpdate(AuditEntry auditEntry, EntityEntry entry)
        {
            if (auditEntry.NewValues.ContainsKey("PasswordHash") && auditEntry.OldValues.ContainsKey("PasswordHash"))
            {
                if (auditEntry.NewValues["PasswordHash"] != auditEntry.OldValues["PasswordHash"])
                {
                    auditEntry.OldValues.Clear();
                    auditEntry.NewValues.Clear();
                    auditEntry.NewValues["Action"] = "Password Updated";
                    auditEntry.NewValues["User"] = ((ApplicationUser)entry.Entity).UserName;

                    return true;
                }
            }
            else if(auditEntry.NewValues.ContainsKey("Action"))
            {
                auditEntry.OldValues.Clear();
                auditEntry.NewValues.Clear();
                auditEntry.NewValues["Action"] = "Password Updated";
                auditEntry.NewValues["User"] = ((ApplicationUser)entry.Entity).UserName;
            }
            return false;

        }


        private bool ManageEmailConfirmation(AuditEntry auditEntry, EntityEntry entry)
        {
            if (auditEntry.NewValues.ContainsKey("EmailConfirmed") && auditEntry.OldValues.ContainsKey("EmailConfirmed"))
            {
                if (auditEntry.NewValues["EmailConfirmed"] != auditEntry.OldValues["EmailConfirmed"])
                {
                    auditEntry.OldValues.Clear();
                    auditEntry.NewValues.Clear();
                    auditEntry.NewValues["EmailConfirmed"] = true;
                    auditEntry.OldValues["EmailConfirmed"] = false;
                    auditEntry.NewValues["User"] = ((ApplicationUser)entry.Entity).UserName;
                    auditEntry.OldValues["User"] = ((ApplicationUser)entry.Entity).UserName;

                    return true;
                }
            }
            return false;

        }


    }
}
