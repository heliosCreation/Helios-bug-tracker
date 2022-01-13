using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Area("Tracker")]
    public class HomeController : Controller
    {
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
