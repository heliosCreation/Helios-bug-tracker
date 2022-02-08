using Microsoft.AspNetCore.Mvc;
using System;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Area("Tracker")]

    public class TicketController : BaseController
    {
        public IActionResult GetAll()
        {
            return View();
        }

        public IActionResult GetTickets(Guid projectID)
        {
            return View("ProjectTickets");
        }
    }
}
