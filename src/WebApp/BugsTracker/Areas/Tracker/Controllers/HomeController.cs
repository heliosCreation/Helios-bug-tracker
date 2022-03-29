using BugTracker.Application.Features.Projects.Queries.GetAll;
using BugTracker.Application.Features.Tickets.Queries.GetTicketDiagramDataByUser;
using BugTracker.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {

        }
        public async Task<IActionResult> DashBoard(int page = 1, bool isSuccess = false, string type = null, string actionReturned = null)
        {
            ViewBag.isSuccess = isSuccess;
            ViewBag.type = type;
            ViewBag.actionReturned = actionReturned;

            var projectResponse = await Mediator.Send(new GetAllProjectQuery(page));


            return View(projectResponse.Data);
        }

        [Produces("application/json")]
        public async Task<IActionResult> GetDiagramsData()
        {
            var response = await Mediator.Send(new GetTicketDiagramDataByUserQuery());
            return Json(response.Data);
        }
    }
}
