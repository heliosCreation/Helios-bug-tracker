using BugTracker.Application.Features.Projects;
using BugTracker.Application.Model.Pagination;
using System.Collections.Generic;

namespace BugTracker.Application.ViewModel
{
    public class DashboardViewModel
    {
        public ICollection<ProjectVm> Projects { get; set; }
        public Pager Pager { get; set; }
    }
}
