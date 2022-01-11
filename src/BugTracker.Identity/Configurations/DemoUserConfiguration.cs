using BugTracker.Application.Model.Identity;
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
                UserName = "masteradmin",
                NormalizedUserName = "MASTERADMIN",
                FirstName = "Master",
                LastName = "Admin",
                Email = "SuperAdmin@Admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            var demoProjectManager = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "John",
                NormalizedUserName = "JOHN",
                FirstName = "John",
                LastName = "Doe",
                Email = "john@gmail.com",
                NormalizedEmail = "JOHN@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };
            var demoDeveloper = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "John",
                NormalizedUserName = "JOHN",
                FirstName = "John",
                LastName = "Doe",
                Email = "john@gmail.com",
                NormalizedEmail = "JOHN@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };
            var demoSubmitter = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "John",
                NormalizedUserName = "JOHN",
                FirstName = "John",
                LastName = "Doe",
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
