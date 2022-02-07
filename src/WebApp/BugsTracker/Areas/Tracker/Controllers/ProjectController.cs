using BugTracker.Application.Dto.Projects;
using BugTracker.Application.Features.Projects.Commands.Create;
using BugTracker.Application.Features.Team.Queries.GetAllAccessibleMembers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Area("Tracker")]
    public class ProjectController : BaseController
    {
        private const string CreateModalPath = "~/Areas/Tracker/Views/Shared/Partial/Project/_createProjectModalPartial.cshtml";
        private const string UpdateModalPath = "~/Areas/Management/Views/Shared/Inspiration/_updateInspirationModal.cshtml";
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


        public async Task<IActionResult> LoadCreateModal()
        {
            var dto = new CreateProjectDto();
            var response = await Mediator.Send(new GetAllAccessibleMembersQuery());
            dto.Team = response.DataList;

            return PartialView(CreateModalPath, dto);
        }
    }
}
