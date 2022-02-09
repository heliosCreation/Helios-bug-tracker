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
    public class TicketsTeamMembersConfiguration : IEntityTypeConfiguration<TicketsTeamMembers>
    {
        public void Configure(EntityTypeBuilder<TicketsTeamMembers> builder)
        {
            builder.HasKey(ttm => new { ttm.TicketId, ttm.UserId });

            builder.HasOne(ttm => ttm.User)
                   .WithMany(ttm => ttm.TicketsTeamMembers)
                   .HasForeignKey(ptm => ptm.UserId);

            builder.HasOne(ttm => ttm.Ticket)
                   .WithMany(ttm => ttm.TicketsTeamMembers)
                   .HasForeignKey(ttm => ttm.TicketId);

        }
    }
}
