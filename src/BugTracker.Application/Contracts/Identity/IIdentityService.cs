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
        Task<string> GeneratePasswordForgottenMailToken(string email);
        Task<string> GenerateRegistrationEncodedToken(string id);
        Task<ICollection<ApplicationUser>> GetAllAccessibleUsers(string uid);
        Task<ApplicationUser> GetUserOrNullAsync(string email);
        Task<IdentityResult> Register(RegistrationModel model);
        Task<IdentityResult> RemoveUserFromRole(ApplicationUser user, string role);
        Task<IdentityResult> ResetPassword(ResetPasswordModel model);
        Task SignOutAsync();
        Task<bool> UserEmailExist(string email);
        Task<bool> UserIdExists(string id);
        Task<bool> UsernameExist(string name);
    }
}
