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
                    Name = "Low"
                },
                new Priority
                {
                    Id = Guid.NewGuid(),
                    Name = "Medium"
                },
                new Priority
                {
                    Id = Guid.NewGuid(),
                    Name = "High"
                },
                new Priority
                {
                    Id = Guid.NewGuid(),
                    Name = "Immediate"
                },
            };

            foreach (var priority in priorities)
            {
                builder.HasData(priority);
            }
        }
    }
}
