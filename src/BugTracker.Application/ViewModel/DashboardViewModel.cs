using BugTracker.Application.Features.Projects;
using BugTracker.Application.Features.Projects.Commands.Create;
using System.Collections.Generic;

namespace BugTracker.Application.ViewModel
{
    public class DashboardViewModel
    {
        public ICollection<ProjectVm> Projects { get; set; }
        public CreateProjectCommand createCommand { get; set; }

        public ICollection<UserViewModel> Team { get; set; }
        //public ICollection<TicketVm> Tickets { get; set; }
    }
}
