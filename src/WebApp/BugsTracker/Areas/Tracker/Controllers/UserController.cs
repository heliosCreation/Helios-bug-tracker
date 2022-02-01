using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Areas.Identity.Controllers
{
    [Area("Tracker")]
    public class UserController : Controller
    {
        public IActionResult ManageUser()
        {
            return View();
        }
    }
}
