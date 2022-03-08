using BugTracker.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BugTracker.Identity.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        private const string demoAdminId = "ae7fffe3-84fe-44f6-ac9f-287b8529f00f";
        private const string demoProjectManagerId = "b7435362-bc74-4a5a-a215-700a8a2760f3";
        private const string demoDeveloperId = "be2ae4ba-1a43-4271-a6a9-14b3b7923f28";
        private const string demoSubmiterId = "980c3882-9373-474d-b9e0-f25d7c00d67e";
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var demoAdmin = new ApplicationUser
            {
                Id = demoAdminId,
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
                Id = demoProjectManagerId,
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
                Id = demoDeveloperId,
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
                Id = demoSubmiterId,
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
