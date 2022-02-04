using BugTracker.Domain.Common;
using System.Collections.Generic;

namespace BugTracker.Domain.Entities
{
    public class Project : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ProjectTeamMember> ProjectTeamMembers { get; set; }

    }
}
