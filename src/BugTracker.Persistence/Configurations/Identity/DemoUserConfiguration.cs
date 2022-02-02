using BugTracker.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BugTracker.Identity.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var demoAdmin = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Demo Admin",
                NormalizedUserName = "DEMO ADMIN",
                Email = "DemoAdmin@Admin.com",
                NormalizedEmail = "DEMOADMIN@ADMIN.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            var demoProjectManager = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Demo Project Manager",
                NormalizedUserName = "DEMO PROJECT MANAGER",
                Email = "demoPM@gmail.com",
                NormalizedEmail = "DEMOPM@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };
            var demoDeveloper = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Demo developer",
                NormalizedUserName = "DEMO DEVELOPER",
                Email = "DemoDev@gmail.com",
                NormalizedEmail = "DEMODEV@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };
            var demoSubmitter = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Demo submitter",
                NormalizedUserName = "DEMO SUBMITTER",
                Email = "john@gmail.com",
                NormalizedEmail = "JOHN@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            demoAdmin.PasswordHash = PassGenerate(demoAdmin);
            demoDeveloper.PasswordHash = PassGenerate(demoDeveloper);
            demoSubmitter.PasswordHash = PassGenerate(demoSubmitter);
            demoProjectManager.PasswordHash = PassGenerate(demoDeveloper);

            builder.HasData(demoAdmin);
            builder.HasData(demoDeveloper);
            builder.HasData(demoSubmitter);
            builder.HasData(demoProjectManager);
        }

        public string PassGenerate(ApplicationUser user)
        {
            var passHash = new PasswordHasher<ApplicationUser>();
            return passHash.HashPassword(user, "Pwd12345!");
        }
    }
}
