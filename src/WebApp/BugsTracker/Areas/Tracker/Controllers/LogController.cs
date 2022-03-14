using BugTracker.Application.Features.Audits.Queries.GetAllLogs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Authorize(Roles = "Admin")]
    public class LogController : BaseController
    {
        public async Task<IActionResult> GetAll(int page = 1, string searchstring = null)
        {
            var response = await Mediator.Send(new GetAllLogsQuery(page, searchstring));
            response.Data.Pager.SearchText = searchstring;
            return View(response.Data);
        }
    }
}
