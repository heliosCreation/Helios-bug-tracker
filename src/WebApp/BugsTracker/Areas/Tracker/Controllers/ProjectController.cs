using BugTracker.Application.Dto.Projects;
using BugTracker.Application.Features.Projects.Commands.Create;
using BugTracker.Application.Features.Projects.Commands.Update;
using BugTracker.Application.Features.Projects.Queries.GetWithTeam;
using BugTracker.Application.Features.Team.Queries.GetAllAccessibleMembers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Area("Tracker")]
    public class ProjectController : BaseController
    {
        private const string CreateModalPath = "~/Areas/Tracker/Views/Shared/Partial/Project/_createProjectModalPartial.cshtml";
        private const string UpdateModalPath = "~/Areas/Tracker/Views/Shared/Partial/Project/_updateProjectModalPartial.cshtml";
        private const string DeleteModalPath = "~/Areas/Management/Views/Shared/Inspiration/_deleteInspirationModal.cshtml";

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "createCommand")] CreateProjectCommand command)
        {
            var response = await Mediator.Send(command);
            if (!response.Succeeded)
            {
                return RedirectToAction("Dashboard", "Home", new { isFailed = true });

            }
            return RedirectToAction("Dashboard", "Home", new { isSuccess = true });
        }

        public async Task<IActionResult> Update([Bind(Prefix = "Command")] UpdateProjectCommand command)
        {
            var response = await Mediator.Send(command);
            if (!response.Succeeded)
            {
                return RedirectToAction("Dashboard", "Home", new { isFailed = true });

            }
            return RedirectToAction("Dashboard", "Home", new { isSuccess = true });
        }

        public async Task<IActionResult> LoadCreateModal()
        {
            var dto = new CreateProjectDto();
            var response = await Mediator.Send(new GetAllAccessibleMembersQuery());
            dto.Team = response.DataList;

            return PartialView(CreateModalPath, dto);
        }

        public async Task<IActionResult> LoadUpdateModal(Guid id)
        {
            var dto = new UpdateProjectDto();
            dto.Command = new UpdateProjectCommand();
            var teamResponse = await Mediator.Send(new GetAllAccessibleMembersQuery());
            var projectResponse = await Mediator.Send(new GetProjectWithTeamQuery() {Id = id });
            dto.Team = teamResponse.DataList;
            dto.Command.Id = projectResponse.Data.Id;
            dto.Command.Name = projectResponse.Data.Name;
            dto.Command.Description = projectResponse.Data.Description;
            dto.Command.Team = projectResponse.Data.TeamIds;

            return PartialView(UpdateModalPath, dto);
        }

        public async Task<IActionResult> LoadDeleteModal()
        {
            var dto = new CreateProjectDto();
            var response = await Mediator.Send(new GetAllAccessibleMembersQuery());
            dto.Team = response.DataList;

            return PartialView(CreateModalPath, dto);
        }
    }
}
