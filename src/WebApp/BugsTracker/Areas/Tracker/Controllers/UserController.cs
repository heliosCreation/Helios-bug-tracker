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
        public async Task<IActionResult> ManageUser()
        {
            var response = await Mediator.Send(new GetAllUsersQuery());
            return View(response.DataList);
        }
    }
}
