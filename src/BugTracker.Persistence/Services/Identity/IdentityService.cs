﻿using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Model.Identity;
using BugTracker.Application.Model.Identity.Authentication;
using BugTracker.Application.Model.Identity.ConfirmationAndReset;
using BugTracker.Application.Model.Identity.Registration;
using BugTracker.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Services.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public IdentityService(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }


        public async Task<IdentityResult> Register(RegistrationModel model)
        {
            var user = new ApplicationUser
            {
                UserName = model.Email,
                NormalizedUserName = model.Email.ToUpper(),
                Email = model.Email,
                NormalizedEmail = model.Email.ToUpper(),
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = false,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString(),
            };

            return await _userManager.CreateAsync(user, model.Password);

        }
        public async Task<string> GenerateRegistrationEncodedToken(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            return WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        }

        public async Task<IdentityResult> ConfirmEmail(string uid, string token)
        {
            token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token));
            return await _userManager.ConfirmEmailAsync(await _userManager.FindByIdAsync(uid), token);
        }

        public async Task<SignInResult> AuthenticateAsync(AuthenticationModel request)
        {
            var signedUser = await _userManager.FindByEmailAsync(request.Email);
            var result = await _signInManager.PasswordSignInAsync(signedUser, request.Password, false, false);
            return result;
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> AddUserToRole(ApplicationUser user, string role)
        {
            return await _userManager.AddToRoleAsync(user, role);

        }

        public async Task<IdentityResult> RemoveUserFromRole(ApplicationUser user, string role)
        {
            return await _userManager.RemoveFromRoleAsync(user, role);
        }

        public async Task<string> GeneratePasswordForgottenMailToken(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            return token;
        }

        public async Task<IdentityResult> ResetPassword(ResetPasswordModel model)
        {
            return await _userManager.ResetPasswordAsync(await _userManager.FindByIdAsync(model.Uid), model.Token, model.NewPassword);
        }



        public async Task<bool> UserEmailExist(string email)
        {
            return await _userManager.FindByEmailAsync(email) != null;
        }

        public async Task<ApplicationUser> GetUserOrNullAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }
        public async Task<bool> UsernameExist(string name)
        {
            return await _userManager.FindByNameAsync(name) != null;
        }



    }
}