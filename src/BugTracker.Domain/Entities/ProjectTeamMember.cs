using BugTracker.Domain.Identity;
using System;

namespace BugTracker.Domain.Entities
{
    public class ProjectTeamMember
    {
        public Project Project { get; set; }
        public Guid ProjectId { get; set; }

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}
