using System;
using System.Collections.Generic;

namespace BugTracker.Application.Features.Projects
{
    public class ProjectVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<string> TeamNames { get; set; }
    }
}
