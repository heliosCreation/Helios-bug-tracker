using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Area("Tracker")]
    public class ProjectController : Controller
    {
        public IActionResult Details(string id)
        {
            return View();
        }
    }
}
