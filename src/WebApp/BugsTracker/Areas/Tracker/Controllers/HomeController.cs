using BugTracker.Application.Features.Projects.Queries.GetAll;
using BugTracker.Application.Features.Team.Queries.GetAllAccessibleMembers;
using BugTracker.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Area("Tracker")]
    public class HomeController : BaseController
    {
        public async Task<IActionResult> DashBoard(bool isSuccess = false, string type = null, string actionReturned = null)
        {
            ViewBag.isSuccess = isSuccess;
            ViewBag.type = type;
            ViewBag.actionReturned = actionReturned;
            var viewModel = new DashboardViewModel();

            var projectResponse = await Mediator.Send(new GetAllProjectQuery());

            viewModel.Projects = projectResponse.DataList;

            return View(viewModel);
        }
    }
}
