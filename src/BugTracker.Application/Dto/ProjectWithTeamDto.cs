using BugTracker.Domain.Entities;
using BugTracker.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.Dto
{
    public class ProjectWithTeamDto
    {
        public Project Project { get; set; }

        public List<ApplicationUser> Team { get; set; } = new List<ApplicationUser>();
    }
}
