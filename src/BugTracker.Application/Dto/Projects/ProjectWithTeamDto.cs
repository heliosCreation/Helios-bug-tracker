using BugTracker.Domain.Entities;
using BugTracker.Domain.Identity;
using System.Collections.Generic;

namespace BugTracker.Application.Dto.Projects
{
    public class ProjectWithTeamDto
    {
        public Project Project { get; set; }

        public List<ApplicationUser> Team { get; set; } = new List<ApplicationUser>();
    }
}
