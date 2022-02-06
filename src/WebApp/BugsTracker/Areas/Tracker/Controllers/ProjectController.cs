using BugTracker.Application.Features.Projects.Commands.Create;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Area("Tracker")]
    public class ProjectController : BaseController
    {
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
    }
}
