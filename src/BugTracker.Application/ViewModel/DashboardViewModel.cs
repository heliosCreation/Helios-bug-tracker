using BugTracker.Application.Features.Projects;
using System.Collections.Generic;

namespace BugTracker.Application.ViewModel
{
    public class DashboardViewModel
    {
        public ICollection<ProjectVm> Projects { get; set; }
        //public ICollection<TicketVm> Tickets { get; set; }
    }
}
