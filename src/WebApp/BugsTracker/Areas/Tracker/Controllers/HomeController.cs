using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Areas.Tracker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
