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
        #region Admin/DemoAdmin
        private const string adminUserId = "21bbccc8-fc2a-4881-b746-ed9d90fbff9b";
        private const string demoAdminUserId = "ae7fffe3-84fe-44f6-ac9f-287b8529f00f";

        private const string adminRoleId = "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65";
        private const string demoAdminRoleId = "5eb35880-6e69-451c-bedc-bd863f6b80f6";
        #endregion

        #region Dev/DemoDev
        private const string dev1UserId = "c31a5e3d-a2ef-4065-a12c-2f9647f24070";
        private const string dev2UserId = "355daad8-1cb5-4caa-8538-e82508b5248a";
        private const string demoDevUserId = "be2ae4ba-1a43-4271-a6a9-14b3b7923f28";

        private const string devRoleId = "04614fbc-b0b7-4344-a2e9-8046742ac7cb";
        private const string demoDevRoleId = "bc03a370-240d-48a6-a37b-efe518b3f065";
        #endregion

        #region Project Manager/ Demo project manager
        private const string projectManager1UserId = "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63";
        private const string projectManager2UserId = "68f84753-8203-45a0-ac1e-b2a06411d49a";
        private const string demoProjectManagerUserId = "b7435362-bc74-4a5a-a215-700a8a2760f3";

        private const string projectManagerRoleId = "6e8006e3-e50a-49be-94ea-03ab653713cc";
        private const string demoProjectManagerRoleId = "776a748a-cd98-42e8-afdb-ae578902a099";
        #endregion

        #region submitter/demo submitter
        private const string submitter1UserId = "b964514f-fc0c-47f2-b16b-dfd7cbf8c167";
        private const string submitter2UserId = "df656ced-7b29-4504-baeb-60d628c56739";
        private const string demoSubmiterUserId = "980c3882-9373-474d-b9e0-f25d7c00d67e";

        private const string submitterRoleId = "6cdee224-4d18-482a-b084-e54fa1788095";
        private const string demoSubmitterRoleId = "96095b44-8c4a-4786-93d3-ee82b5b29481";
        #endregion


        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            #region IdentityUserRole
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
            #endregion

            #region demo IdenityUserRole
            var iurDemoAdmin = new IdentityUserRole<string>
            {
                RoleId = demoAdminRoleId,
                UserId = demoAdminUserId
            };

            var iurDemoDev = new IdentityUserRole<string>
            {
                RoleId = demoDevRoleId,
                UserId = demoDevUserId
            };

            var iurDemoProjectManager = new IdentityUserRole<string>
            {
                RoleId = demoProjectManagerRoleId,
                UserId = demoProjectManagerUserId
            };

            var iurDemoSubmitter = new IdentityUserRole<string>
            {
                RoleId = demoSubmitterRoleId,
                UserId = demoSubmiterUserId
            };

            builder.HasData(iurDemoAdmin);
            builder.HasData(iurDemoDev);
            builder.HasData(iurDemoProjectManager);
            builder.HasData(iurDemoSubmitter);

            #endregion

        }
    }
}
