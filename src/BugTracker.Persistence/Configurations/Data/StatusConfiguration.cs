using BugTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace BugTracker.Persistence.Configurations.Data
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            var statuses = new List<Status>()
            {
                new Status
                {
                    Id = Guid.NewGuid(),
                    Name = "New"
                },
                new Status
                {
                    Id = Guid.NewGuid(),
                    Name = "Open"
                },
                new Status
                {
                    Id = Guid.NewGuid(),
                    Name = "In progress"
                },
                new Status
                {
                    Id = Guid.NewGuid(),
                    Name = "Resolved"
                },
            };

            foreach (var status in statuses)
            {
                builder.HasData(status);
            }
        }
    }
}
