using BugTracker.Application.Model.Auditing;
using BugTracker.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        public async Task MapEntries(List<AuditEntry> auditEntries, string userId)
        {
            foreach (var entry in _dbContext.ChangeTracker.Entries())
            {
                if (entry.Entity is Audit || entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                    continue;

                var auditEntry = new AuditEntry(entry);
                auditEntry.TableName = entry.Entity.GetType().Name;
                auditEntry.UserId = userId;
                auditEntries.Add(auditEntry);
                await MapPropertiesToEntryValue(entry, auditEntry);
            }

        }
        public async Task MapPropertiesToEntryValue(EntityEntry entry, AuditEntry auditEntry)
        {
            foreach (var property in entry.Properties)
            {
                var current = property.CurrentValue;

                MapPKToAuditEntryValue(property, auditEntry, current);
                if (property.Metadata.Name == "UserId")
                {
                    current = await MapUserIdToLogValues(property);
                }
                AssignValuesBasedOnEntryState(auditEntry, current, property, entry);
            }

        }
        public void MapPKToAuditEntryValue(PropertyEntry property, AuditEntry auditEntry, object current)
        {
            if (property.Metadata.IsPrimaryKey())
            {
                auditEntry.KeyValues[property.Metadata.Name] = current;
            }
        }
        public async Task<object> MapUserIdToLogValues(PropertyEntry property)
        {
            var rolesId = await _dbContext.UserRoles.Where(ur => ur.UserId == (string)property.CurrentValue).Select(ur => ur.RoleId).ToListAsync();
            var roles = await _dbContext.Roles.Where(r => rolesId.Any(roleId => r.Id == roleId)).Select(r => r.Name).ToListAsync();

            return JsonSerializer.Serialize(new
            {
                Id = property.CurrentValue,
                Name = await _dbContext.Users.Where(u => u.Id == (string)property.CurrentValue).Select(u => u.UserName).FirstOrDefaultAsync(),
                Roles = roles
            });
        }
        public void AssignValuesBasedOnEntryState(AuditEntry auditEntry, object current, PropertyEntry property, EntityEntry entry)
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    auditEntry.AuditType = Application.Enums.AuditType.Create;
                    auditEntry.NewValues[property.Metadata.Name] = current;
                    break;
                case EntityState.Deleted:
                    auditEntry.AuditType = Application.Enums.AuditType.Delete;
                    auditEntry.OldValues[property.Metadata.Name] = current;
                    break;
                case EntityState.Modified:
                    if (property.IsModified)
                    {
                        auditEntry.ChangedColumns.Add(property.Metadata.Name);
                        auditEntry.AuditType = Application.Enums.AuditType.Update;
                        auditEntry.OldValues[property.Metadata.Name] = property.OriginalValue;
                        auditEntry.NewValues[property.Metadata.Name] = current;
                    }
                    break;
            }

        }
    }
}
