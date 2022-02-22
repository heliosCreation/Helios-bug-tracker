using System;

namespace BugTracker.Domain.Entities
{
    public class Priority
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
