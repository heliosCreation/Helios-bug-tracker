using System;
using System.Collections.Generic;

namespace BugTracker.Application.Features.Projects
{
    public class ProjectWithTeamIdsVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<string> TeamIds { get; set; }
    }
}
