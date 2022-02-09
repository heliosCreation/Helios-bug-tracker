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
                Id = "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "quentin.coui@hotmail.com",
                NormalizedEmail = "QUENTIN.COUI@HOTMAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            var dev = new ApplicationUser
            {
                Id = "355daad8-1cb5-4caa-8538-e82508b5248a",
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
                Id = "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
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
                Id = "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                UserName = "Jack nicklefrost",
                NormalizedUserName = "JACK NICKEFROST",
                Email = "jack.nicklefrost@hotmail.com",
                NormalizedEmail = "JACK.NICKLEFROST@HOTMAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            var projectManager2 = new ApplicationUser
            {
                Id = "68f84753-8203-45a0-ac1e-b2a06411d49a",
                UserName = "Hanna steinbeck",
                NormalizedUserName = "HANNA STEINBECK",
                Email = "hanna.steinbeck@hotmail.com",
                NormalizedEmail = "HANNA.STEINBECK@HOTMAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            var submitter = new ApplicationUser
            {
                Id = "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                UserName = "Alice cooper",
                NormalizedUserName = "ALICE COOPER",
                Email = "alice.cooper@hotmail.com",
                NormalizedEmail = "ALICE.COOPER@HOTMAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };


            var submitter2 = new ApplicationUser
            {
                Id = "df656ced-7b29-4504-baeb-60d628c56739",
                UserName = "Dean Moriarty",
                NormalizedUserName = "DEAN MORIARTY",
                Email = "dean.moriarty@hotmail.com",
                NormalizedEmail = "DEAN.MORIARTY@HOTMAIL.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            admin.PasswordHash = PassGenerate(admin);
            dev.PasswordHash = PassGenerate(dev);
            dev2.PasswordHash = PassGenerate(dev2);
            submitter.PasswordHash = PassGenerate(submitter);
            submitter2.PasswordHash = PassGenerate(submitter2);
            projectManager.PasswordHash = PassGenerate(projectManager);
            projectManager2.PasswordHash = PassGenerate(projectManager2);

            builder.HasData(admin);
            builder.HasData(dev);
            builder.HasData(dev2);
            builder.HasData(projectManager);
            builder.HasData(projectManager2);
            builder.HasData(submitter);
            builder.HasData(submitter2);
        }

        public string PassGenerate(ApplicationUser user)
        {
            var passHash = new PasswordHasher<ApplicationUser>();
            return passHash.HashPassword(user, "Pwd12345!");
        }
    }
}
