using BugTracker.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BugTracker.Persistence.Configurations.Identity
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var admin = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "quentin.coui@hotmail.com",
                NormalizedEmail = "QUENTIN.COUI@HOTMAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            var dev1 = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "John doe",
                NormalizedUserName = "JOHN DOE",
                Email = "john.doe@hotmail.com",
                NormalizedEmail = "JOHN.DOE@HOTMAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            var dev2 = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Jane doe",
                NormalizedUserName = "JANE DOE",
                Email = "jane.doe@hotmail.com",
                NormalizedEmail = "JANE.DOE@HOTMAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            var projectManager = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Jack nicklefrost",
                NormalizedUserName = "JACK NICKEFROST",
                Email = "jack.nicklefrost@hotmail.com",
                NormalizedEmail = "JACK.NICKLEFROST@HOTMAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            var submitter = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Alice cooper",
                NormalizedUserName = "ALICE COOPER",
                Email = "alice.cooper@hotmail.com",
                NormalizedEmail = "ALICE.COOPER@HOTMAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            admin.PasswordHash = PassGenerate(admin);
            dev1.PasswordHash = PassGenerate(dev1);
            dev2.PasswordHash = PassGenerate(dev2);
            submitter.PasswordHash = PassGenerate(submitter);
            projectManager.PasswordHash = PassGenerate(projectManager);

            builder.HasData(admin);
            builder.HasData(dev1);
            builder.HasData(dev2);
            builder.HasData(projectManager);
            builder.HasData(submitter);
        }

        public string PassGenerate(ApplicationUser user)
        {
            var passHash = new PasswordHasher<ApplicationUser>();
            return passHash.HashPassword(user, "Pwd12345!");
        }
    }
}
