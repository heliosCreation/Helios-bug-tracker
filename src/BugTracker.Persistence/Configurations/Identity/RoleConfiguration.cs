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
                Id = "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            builder.HasData(new IdentityRole
            {
                Id = "6e8006e3-e50a-49be-94ea-03ab653713cc",
                Name = "Project Manager",
                NormalizedName = "PROJECT MANAGER"
            });

            builder.HasData(new IdentityRole
            {
                Id = "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                Name = "Developer",
                NormalizedName = "DEVELOPER"
            });

            builder.HasData(new IdentityRole
            {
                Id = "6cdee224-4d18-482a-b084-e54fa1788095",
                Name = "Submitter",
                NormalizedName = "SUBMITTER"
            });
            
            builder.HasData(new IdentityRole
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
