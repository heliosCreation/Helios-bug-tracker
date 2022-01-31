using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Area("Tracker")]

    public class TicketController : Controller
    {
        public IActionResult Details(int Id)
        {
            return View();
        }
    }
}
