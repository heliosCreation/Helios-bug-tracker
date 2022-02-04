using BugTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Configurations.Data
{
    public class ProjectTeamMemberConfiguration : IEntityTypeConfiguration<ProjectTeamMember>
    {
        public void Configure(EntityTypeBuilder<ProjectTeamMember> builder)
        {
            builder.HasKey(ptm => new { ptm.ProjectId, ptm.UserId });

            builder.HasOne(ptm => ptm.User)
                   .WithMany(ptm => ptm.ProjectTeamMembers)
                   .HasForeignKey(ptm => ptm.UserId);

            builder.HasOne(ptm => ptm.Project)
                   .WithMany(ptm => ptm.ProjectTeamMembers)
                   .HasForeignKey(ptm => ptm.ProjectId);

        }
    }
}
