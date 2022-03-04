using BugTracker.Application.Dto.UserManagement;
using BugTracker.Application.Features.UserManagement.Commands.UpdateUserRole;
using BugTracker.Application.Features.UserManagement.GetAllRoles;
using BugTracker.Application.Features.UserManagement.GetAllUsers;
using BugTracker.Application.Features.UserManagement.GetUserWithRoles;
using BugTracker.Application.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Area("Tracker")]
    [Authorize(Roles ="Admin")]
    public class UserController : BaseController
    {
        private const string ModalBasePath = "~/Areas/Tracker/Views/Shared/Partial/UserManagement/";
        private const string ModalType = "UserManagementModalPartial.cshtml";

        private const string ManageRolesModalPath = ModalBasePath + "_manageRole" + ModalType;

        public async Task<IActionResult> GetAll(int page = 1, string searchString = null)
        {
            var response = await Mediator.Send(new GetAllUsersQuery(page,searchString));
            return View(response.Data);
        }

        public async Task<IActionResult> LoadManageRoleModal(string uid)
        {
            var vm = new ManageUserRoleViewModel();

            var userRolesResponse = await Mediator.Send(new GetUserWithRoleQuery(uid));
            var rolesResponse = await Mediator.Send(new GetAllRolesQuery());

            vm.UserWithRoles = userRolesResponse.Data; 
            vm.AvailableRoles = rolesResponse.DataList;

            return PartialView(ManageRolesModalPath, vm);
        }

        public async Task<IActionResult> ManageUserRoles(UserWithRoleDto userWithRoles)
        {
            var response = await Mediator.Send(new UpdateUserRolesCommand(userWithRoles.UserId, userWithRoles.SelectedRoles));
            if (!response.Succeeded)
            {
                //TODO manage errors
            }

            return RedirectToAction("GetAll");
        }

    }
}
