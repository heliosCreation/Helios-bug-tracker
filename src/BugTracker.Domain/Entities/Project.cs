using BugTracker.Domain.Common;
using BugTracker.Domain.Identity;
using System.Collections.Generic;

namespace BugTracker.Domain.Entities
{
    public class Project : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ApplicationUser> Team { get; set; } = new List<ApplicationUser>();
        public ICollection<Ticket> Tickets { get; set; }
    }
}
