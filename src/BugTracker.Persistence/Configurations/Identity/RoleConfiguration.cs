using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BugTracker.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {

        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            builder.HasData(new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Project Manager",
                NormalizedName = "PROJECT MANAGER"
            });

            builder.HasData(new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Developer",
                NormalizedName = "DEVELOPER"
            });

            builder.HasData(new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Submitter",
                NormalizedName = "SUBMITTER"
            }); builder.HasData(new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Demo Admin",
                NormalizedName = "DEMO_ADMIN"
            });

            builder.HasData(new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = " Demo Project Manager",
                NormalizedName = "DEMO PROJECT MANAGER"
            });

            builder.HasData(new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Demo Developer",
                NormalizedName = "DEMO DEVELOPER"
            });

            builder.HasData(new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Demo Submitter",
                NormalizedName = "DEMO SUBMITTER"
            });
        }
    }
}
