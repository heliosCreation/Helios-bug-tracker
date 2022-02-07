using BugTracker.Application.Features.Projects.Commands.Create;
using BugTracker.Application.Features.Projects.Commands.Update;
using BugTracker.Application.ViewModel;
using System.Collections.Generic;

namespace BugTracker.Application.Dto.Projects
{
    public class UpdateProjectDto
    {
        public UpdateProjectCommand Command { get; set; }

        public List<UserViewModel> Team { get; set; }
    }
}
