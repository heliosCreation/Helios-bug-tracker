using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

using Type = BugTracker.Domain.Entities.Type;

namespace BugTracker.Persistence.Configurations.Data
{
    public class TypeConfiguration : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            var types = new List<Type>()
            {
                new Type
                {
                    Id = Guid.NewGuid(),
                    Name = "Bug - Error",
                    Order = 1
                },
                new Type
                {
                    Id = Guid.NewGuid(),
                    Name = "Feature request",
                    Order = 2,
                },
                new Type
                {
                    Id = Guid.NewGuid(),
                    Name = "Training",
                    Order = 3
                },
                new Type
                {
                    Id = Guid.NewGuid(),
                    Name = "Documentation",
                    Order = 4
                },
            };

            foreach (var type in types)
            {
                builder.HasData(type);
            }
        }
    }
}
