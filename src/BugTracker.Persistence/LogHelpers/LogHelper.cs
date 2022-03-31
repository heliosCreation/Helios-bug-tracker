using BugTracker.Application.Model.Auditing;
using BugTracker.Domain.Common;
using BugTracker.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
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
                if (property.Metadata.IsForeignKey())
                {
                    current = await MapFKToAuditEntryValue(entries, property, auditEntry, current);
                }
                AssignValuesBasedOnEntryState(auditEntry, current, property, entry);
            }

        }
        private async Task<object> MapFKToAuditEntryValue(IEnumerable<EntityEntry> entries, PropertyEntry property, AuditEntry auditEntry, object current)
        {
            var name = property.Metadata.Name.ToLower();

            if (name.Contains("priority"))
            {
                current = await _dbContext.Priority.Where(p => p.Id == (Guid)current).Select(p => p.Name).FirstOrDefaultAsync();
            }
            else if (name.Contains("type"))
            {
                current = await _dbContext.Type.Where(p => p.Id == (Guid)current).Select(p => p.Name).FirstOrDefaultAsync();
            }
            else if (name.Contains("status"))
            {
                current = await _dbContext.Status.Where(p => p.Id == (Guid)current).Select(p => p.Name).FirstOrDefaultAsync();
            }
            else if(name.Contains("project"))
            {
                current = await _dbContext.Projects.Where(p => p.Id == (Guid)current).Select(p => p.Name).FirstOrDefaultAsync();
                if (current == null)
                {
                    current = entries.ToList()[0].Property("Name").CurrentValue;
                }
            }
            else if (name.Contains("user"))
            {
                current = await _dbContext.Users.Where(u => u.Id == (string)property.CurrentValue).Select(u => u.UserName).FirstOrDefaultAsync();
            }
            else if (name.Contains("role"))
            {
                current = await _dbContext.Roles.Where(r => r.Id == (string)current).Select(p => p.Name).FirstOrDefaultAsync();
            }
            return current; 
        }

        private void AssignValuesBasedOnEntryState(AuditEntry auditEntry, object current, PropertyEntry property, EntityEntry entry)
        {
            var blackList = new List<string> {"Id", "CreatedBy", "LastModifiedBy", "CreatedDate", "LastModifiedDate", "ApplicationUserId" };
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
                        auditEntry.OldValues[property.Metadata.Name] = current;
                    }
                    break;
                case EntityState.Modified:
                    if (property.IsModified)
                    {
                        auditEntry.ChangedColumns.Add(property.Metadata.Name);
                        auditEntry.AuditType = Application.Enums.AuditType.Update;
                        auditEntry.OldValues[property.Metadata.Name] = property.OriginalValue;
                        auditEntry.NewValues[property.Metadata.Name] = current;
                        if (auditEntry.TableName == "ApplicationUser")
                        {
                            auditEntry.NewValues["User"] = ((ApplicationUser)entry.Entity).UserName;
                            auditEntry.OldValues["User"] = ((ApplicationUser)entry.Entity).UserName;
                        }
                    }
                    break;
            }

        }
    }
}
