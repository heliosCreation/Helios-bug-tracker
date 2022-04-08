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

        public async Task<IActionResult> GetAll(int page = 1, string searchString = null, bool showLocked = false, bool showNoRole = false,
            bool isSuccess = false, bool isFailed = false, List<string> errors = null, string type = null, string actionReturned = null)
        {
            ViewBag.isSuccess = isSuccess;
            ViewBag.isFailed = isFailed;
            ViewBag.errors = errors;
            ViewBag.type = type;
            ViewBag.actionReturned = actionReturned;

            var response = await Mediator.Send(new GetAllUsersQuery(page, searchString, showLocked, showNoRole));
            return View(response.Data);
        }

        public async Task<IActionResult> LoadManageRoleModal(string uid, [FromQuery] int page)
        {
            var vm = new ManageUserRoleViewModel();

            var userRolesResponse = await Mediator.Send(new GetUserWithRoleQuery(uid));
            var rolesResponse = await Mediator.Send(new GetAllRolesQuery());

            vm.UserWithRoles = userRolesResponse.Data; 
            vm.AvailableRoles = rolesResponse.DataList;
            vm.Page = page;

            return PartialView(ManageRolesModalPath, vm);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ManageUserRoles(UserWithRoleDto userWithRoles,int page)
        {
            var response = await Mediator.Send(new UpdateUserRolesCommand(userWithRoles.UserId, userWithRoles.SelectedRoles));
            if (!response.Succeeded)
            {
                //TODO manage errors
            }

            return RedirectToAction("GetAll", new { isSuccess = true, type = "user role", actionReturned = "uptaded", page = page });
        }
        
        public IActionResult LoadLockUserModal(string uid, [FromQuery] int page)
        {
            var vm = new ManageUserStateViewModel(uid,page);
            return PartialView(LockUserModalPath, vm);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult>Lock(string uid, int page)
        {
            var lockResponse = await Mediator.Send(new LockUserCommand(uid));
            if (!lockResponse.Succeeded)
            {
                return RedirectToAction("GetAll", new {isFailed = true, errors = lockResponse.ErrorMessages, page = page });
            }

            return RedirectToAction("GetAll", new { isSuccess = true, type = "user", actionReturned = "locked", page = page});
        }
        
        public IActionResult LoadUnlockUserModal(string uid, [FromQuery] int page)
        {
            var vm = new ManageUserStateViewModel(uid, page);

            return PartialView(UnlockUserModalPath, vm);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UnLock(string uid, int page)
        {
            var lockResponse = await Mediator.Send(new UnlockUserCommand(uid));
            if (!lockResponse.Succeeded)
            {
                return RedirectToAction("GetAll", new {isFailed = true, errors = lockResponse.ErrorMessages, type = "user", actionReturned = "unlocked", page = page });
            }

            return RedirectToAction("GetAll", new { isSuccess = true, type = "user", actionReturned = "unlocked",page = page });
        }
        
        public IActionResult LoadDeleteUserModal(string uid, [FromQuery]int page)
        {
            var vm = new ManageUserStateViewModel(uid, page);
            return PartialView(DeleteUserModalPath, vm);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string uid, int page)
        {
            var deleteResponse = await Mediator.Send(new DeleteUserCommand(uid));
            if (!deleteResponse.Succeeded)
            {
                return RedirectToAction("GetAll", new { isFailed = true, errors = deleteResponse.ErrorMessages, type = "user", actionReturned = "deleted" });
            }

            return RedirectToAction("GetAll", new { isSuccess = true, type = "user", actionReturned = "deleted", page = page });
        }
    }
}
