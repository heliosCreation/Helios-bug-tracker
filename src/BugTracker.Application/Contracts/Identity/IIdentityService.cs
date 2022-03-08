using BugTracker.Application.Model.Identity.Authentication;
using BugTracker.Application.Model.Identity.ConfirmationAndReset;
using BugTracker.Application.Model.Identity.Registration;
using BugTracker.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Identity
{
    public interface IIdentityService
    {
        Task<IdentityResult> AddUserToRole(ApplicationUser user, string role);
        Task<SignInResult> AuthenticateAsync(AuthenticationModel request);
        Task<IdentityResult> ConfirmEmail(string email, string token);
        Task<int> CountManageableUsers();
        Task<IdentityResult> DeleteUserAsync(string uid);
        Task<string> GeneratePasswordForgottenMailToken(string email);
        Task<string> GenerateRegistrationEncodedToken(string id);
        Task<ICollection<ApplicationUser>> GetAccessibleTicketTeam(string uid, Guid projectId);
        Task<ICollection<ApplicationUser>> GetAllAccessibleUsersPerRole(string uid);
        Task<IEnumerable<ApplicationUser>> GetAllManageableUsers(int page, string searchString, bool showLocked);
        Task<ICollection<ApplicationUser>> GetCurrentTicketTeam(Guid ticketId);
        Task<string> GetUserNameById(string id);
        Task<ApplicationUser> GetUserOrNullAsync(string email);
        Task<ICollection<IdentityRole<string>>> GetUserRolesById(string id);
        Task<IEnumerable<IdentityRole<string>>> ListAllRoles();
        Task<bool> LockOutUser(string uid);
        Task<IdentityResult> Register(RegistrationModel model);
        Task<IdentityResult> RemoveUserFromRole(ApplicationUser user, string role);
        Task<IdentityResult> ResetPassword(ResetPasswordModel model);
        Task SignOutAsync();
        Task<bool> UnlockUser(string uid);
        Task<bool> UpdateUserRoles(string uid, List<string> rolesIds);
        Task<bool> UserEmailExist(string email);
        Task<bool> UserIdExists(string id);
        Task<bool> UsernameExist(string name);
    }
}
