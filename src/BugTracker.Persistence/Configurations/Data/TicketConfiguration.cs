using BugTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugTracker.Persistence.Configurations.Data
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder           
                .Property(u => u.Type)
                .HasConversion<string>()
                .HasMaxLength(15);

            builder
                .Property(u => u.Status)
                .HasConversion<string>()
                .HasMaxLength(15);

            builder
                .Property(u => u.Priority)
                .HasConversion<string>()
                .HasMaxLength(15);

        }
    }
}
