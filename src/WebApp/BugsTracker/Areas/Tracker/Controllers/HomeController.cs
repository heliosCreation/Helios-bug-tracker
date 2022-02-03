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
        public async Task<IActionResult> DashBoard()
        {
            var viewModel = new DashboardViewModel();

            var projectResponse = await Mediator.Send(new GetAllProjectQuery());
            var teamResponse = await Mediator.Send(new GetAllAccessibleMembersQuery());

            viewModel.Projects = projectResponse.DataList;
            viewModel.Team = teamResponse.DataList;

            return View(viewModel);
        }
    }
}
