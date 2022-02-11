using BugTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace BugTracker.Persistence.Configurations.Data
{
    public class PriorityConfiguration : IEntityTypeConfiguration<Priority>
    {
        public void Configure(EntityTypeBuilder<Priority> builder)
        {
            var priorities = new List<Priority>()
            {
                new Priority
                {
                    Id = Guid.NewGuid(),
                    Name = "Low",
                    Order = 1
                },
                new Priority
                {
                    Id = Guid.NewGuid(),
                    Name = "Medium",
                    Order = 2
                },
                new Priority
                {
                    Id = Guid.NewGuid(),
                    Name = "High",
                    Order = 3,
                },
                new Priority
                {
                    Id = Guid.NewGuid(),
                    Name = "Immediate",
                    Order = 4
                },
            };

            foreach (var priority in priorities)
            {
                builder.HasData(priority);
            }
        }
    }
}
