using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Model.Auditing;
using BugTracker.Domain.Common;
using BugTracker.Domain.Entities;
using BugTracker.Domain.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

using Type = BugTracker.Domain.Entities.Type;

namespace BugTracker.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
            
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTeamMember> ProjectTeamMembers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Priority> Priority { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Type> Type { get; set; }
        public DbSet<TicketsTeamMembers> TicketsTeamMembers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Audit> AuditLogs { get; set; }



        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            await OnBeforeSaveChangesAsync(_httpContextAccessor.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier));

            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = Guid.Parse(_httpContextAccessor.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier));
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = Guid.Parse(_httpContextAccessor.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier));
                        break;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

        private async Task OnBeforeSaveChangesAsync(string userId)
        {
            ChangeTracker.DetectChanges();
            var auditEntries = new List<AuditEntry>();

            await MapEntries(auditEntries, userId);

            foreach (var auditEntry in auditEntries)
            {
                var auditLog = auditEntry.ToAudit();
                await AuditLogs.AddAsync(auditLog);
            }
        }


        private async Task MapEntries(List<AuditEntry> auditEntries, string userId)
        {
            foreach (var entry in ChangeTracker.Entries())
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
    
        private async Task MapPropertiesToEntryValue(EntityEntry entry, AuditEntry auditEntry)
        {
            foreach (var property in entry.Properties)
            {
                var current = property.CurrentValue;

                MapPKToAuditEntryValue(property, auditEntry, current);
                await MapUserIdToLogValuesIfNecessary(property, current);
                AssignValuesBasedOnEntryState(auditEntry, current, property, entry);
            }

        }
        
        private void MapPKToAuditEntryValue(PropertyEntry property, AuditEntry auditEntry, object current)
        {
            if (property.Metadata.IsPrimaryKey())
            {
                auditEntry.KeyValues[property.Metadata.Name] = current;
            }
        }
        private async Task MapUserIdToLogValuesIfNecessary(PropertyEntry property, object current)
        {
            if (property.Metadata.Name == "UserId")
            {
                var rolesId = await this.UserRoles.Where(ur => ur.UserId == (string)property.CurrentValue).Select(ur => ur.RoleId).ToListAsync();
                var roles = await this.Roles.Where(r => rolesId.Any(roleId => r.Id == roleId)).Select(r => r.Name).ToListAsync();

                current = JsonSerializer.Serialize(new
                {
                    Id = property.CurrentValue,
                    Name = await this.Users.Where(u => u.Id == (string)property.CurrentValue).Select(u => u.UserName).FirstOrDefaultAsync(),
                    Roles = roles
                });
            }
        }
    
        private void AssignValuesBasedOnEntryState(AuditEntry auditEntry, object current, PropertyEntry property, EntityEntry entry)
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
