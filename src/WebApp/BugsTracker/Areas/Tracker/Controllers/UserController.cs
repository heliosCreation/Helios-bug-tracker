using BugTracker.Application.Features.UserManagement.GetAllUsers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Area("Tracker")]
    [Authorize(Roles ="Admin")]
    public class UserController : BaseController
    {
        public async Task<IActionResult> ManageUser(int page = 1, string searchString = null)
        {
            var response = await Mediator.Send(new GetAllUsersQuery(page,searchString));
            return View(response.Data);
        }
    }
}
