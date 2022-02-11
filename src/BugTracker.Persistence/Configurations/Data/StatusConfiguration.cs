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
                    Name = "New",
                    Order = 1
                },
                new Status
                {
                    Id = Guid.NewGuid(),
                    Name = "Open",
                    Order = 2
                },
                new Status
                {
                    Id = Guid.NewGuid(),
                    Name = "In progress",
                    Order = 3
                },
                new Status
                {
                    Id = Guid.NewGuid(),
                    Name = "Resolved",
                    Order = 4

                },
            };

            foreach (var status in statuses)
            {
                builder.HasData(status);
            }
        }
    }
}
