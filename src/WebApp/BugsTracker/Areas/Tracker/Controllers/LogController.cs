using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    public class LogController : BaseController
    {
        public async Task<IActionResult> GetAll()
        {
            return View();
        }
    }
}
