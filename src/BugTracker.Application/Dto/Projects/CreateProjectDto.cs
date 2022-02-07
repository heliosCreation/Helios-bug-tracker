using BugTracker.Application.Features.Projects.Commands.Create;
using BugTracker.Application.ViewModel;
using System.Collections.Generic;

namespace BugTracker.Application.Dto.Projects
{
    public class CreateProjectDto
    {
        public CreateProjectCommand Command { get; set; }

        public List<UserViewModel> Team { get; set; }
    }
}
