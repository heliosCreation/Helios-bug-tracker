using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Area("Tracker")]

    public class TicketController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
