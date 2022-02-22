using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Configurations.Identity
{
    public class UserRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        private const string adminUserId = "21bbccc8-fc2a-4881-b746-ed9d90fbff9b";
        private const string adminRoleId = "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65";

        private const string dev1UserId = "c31a5e3d-a2ef-4065-a12c-2f9647f24070";
        private const string dev2UserId = "355daad8-1cb5-4caa-8538-e82508b5248a";
        private const string devRoleId = "04614fbc-b0b7-4344-a2e9-8046742ac7cb";

        private const string projectManager1UserId = "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63";
        private const string projectManager2UserId = "68f84753-8203-45a0-ac1e-b2a06411d49a";
        private const string projectManagerRoleId = "6e8006e3-e50a-49be-94ea-03ab653713cc";


        private const string submitter1UserId = "b964514f-fc0c-47f2-b16b-dfd7cbf8c167";
        private const string submitter2UserId = "df656ced-7b29-4504-baeb-60d628c56739";
        private const string submitterRoleId = "6cdee224-4d18-482a-b084-e54fa1788095";



        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            var iurAdmin = new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminUserId
            };
            var iurDev1 = new IdentityUserRole<string>
            {
                RoleId = devRoleId,
                UserId = dev1UserId
            };
            
            var iurDev2 = new IdentityUserRole<string>
            {
                RoleId = devRoleId,
                UserId = dev2UserId
            };
            var iurProjectManager1 = new IdentityUserRole<string>
            {
                RoleId = projectManagerRoleId,
                UserId = projectManager1UserId
            };
            var iurProjectManager2 = new IdentityUserRole<string>
            {
                RoleId = projectManagerRoleId,
                UserId = projectManager2UserId
            };
            var iurSubmitter1 = new IdentityUserRole<string>
            {
                RoleId = submitterRoleId,
                UserId = submitter1UserId
            };
            var iurSubmitter2 = new IdentityUserRole<string>
            {
                RoleId = submitterRoleId,
                UserId = submitter2UserId
            };
            builder.HasData(iurAdmin);
            builder.HasData(iurDev1);
            builder.HasData(iurDev2);
            builder.HasData(iurProjectManager1);
            builder.HasData(iurProjectManager2);
            builder.HasData(iurSubmitter1);
            builder.HasData(iurSubmitter2);
        }
    }
}
