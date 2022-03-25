using BugTracker.Application.Dto.UserManagement;
using BugTracker.Application.Features.UserManagement.Commands.DeleteUser;
using BugTracker.Application.Features.UserManagement.Commands.LockUser;
using BugTracker.Application.Features.UserManagement.Commands.UnlockUser;
using BugTracker.Application.Features.UserManagement.Commands.UpdateUserRole;
using BugTracker.Application.Features.UserManagement.GetAllRoles;
using BugTracker.Application.Features.UserManagement.GetAllUsers;
using BugTracker.Application.Features.UserManagement.GetUserWithRoles;
using BugTracker.Application.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Areas.Tracker.Controllers
{
    [Authorize(Roles ="Admin, Demo Admin")]
    public class UserController : BaseController
    {
        private const string ModalBasePath = "~/Areas/Tracker/Views/Shared/Partial/UserManagement/";
        private const string ModalType = "UserManagementModalPartial.cshtml";

        private const string ManageRolesModalPath = ModalBasePath + "_manageRole" + ModalType;
        private const string LockUserModalPath = ModalBasePath + "_lock" + ModalType;
        private const string UnlockUserModalPath = ModalBasePath + "_unlock" + ModalType;
        private const string DeleteUserModalPath = ModalBasePath + "_delete" + ModalType;

        public async Task<IActionResult> GetAll(int page = 1, string searchString = null, bool showLocked = false,
            bool isSuccess = false, bool isFailed = false, List<string> errors = null, string type = null, string actionReturned = null)
        {
            ViewBag.isSuccess = isSuccess;
            ViewBag.isFailed = isFailed;
            ViewBag.errors = errors;
            ViewBag.type = type;
            ViewBag.actionReturned = actionReturned;

            var response = await Mediator.Send(new GetAllUsersQuery(page, searchString, showLocked));
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

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ManageUserRoles(UserWithRoleDto userWithRoles)
        {
            var response = await Mediator.Send(new UpdateUserRolesCommand(userWithRoles.UserId, userWithRoles.SelectedRoles));
            if (!response.Succeeded)
            {
                //TODO manage errors
            }

            return RedirectToAction("GetAll");
        }
        
        public IActionResult LoadLockUserModal(string uid)
        {
            return PartialView(LockUserModalPath, uid);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult>Lock(string uid)
        {
            var lockResponse = await Mediator.Send(new LockUserCommand(uid));
            if (!lockResponse.Succeeded)
            {
                return RedirectToAction("GetAll", new {isFailed = true, errors = lockResponse.ErrorMessages });
            }

            return RedirectToAction("GetAll", new { isSuccess = true, type = "user", actionReturned = "locked"});
        }
        
        public IActionResult LoadUnlockUserModal(string uid)
        {
            return PartialView(UnlockUserModalPath, uid);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UnLock(string uid)
        {
            var lockResponse = await Mediator.Send(new UnlockUserCommand(uid));
            if (!lockResponse.Succeeded)
            {
                return RedirectToAction("GetAll", new {isFailed = true, errors = lockResponse.ErrorMessages, type = "user", actionReturned = "unlocked" });
            }

            return RedirectToAction("GetAll", new { isSuccess = true, type = "user", actionReturned = "unlocked" });
        }
        
        public IActionResult LoadDeleteUserModal(string uid)
        {
            return PartialView(DeleteUserModalPath, uid);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string uid)
        {
            var deleteResponse = await Mediator.Send(new DeleteUserCommand(uid));
            if (!deleteResponse.Succeeded)
            {
                return RedirectToAction("GetAll", new { isFailed = true, errors = deleteResponse.ErrorMessages, type = "user", actionReturned = "deleted" });
            }

            return RedirectToAction("GetAll", new { isSuccess = true, type = "user", actionReturned = "deleted" });
        }
    }
}
