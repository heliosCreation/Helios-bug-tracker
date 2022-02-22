using System;

namespace BugTracker.Domain.Entities
{
    public class Type
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
