using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Contracts.Infrastructure.Mail;
using BugTracker.Application.Model.Identity.Authentication;
using BugTracker.Application.Model.Identity.ConfirmationAndReset;
using BugTracker.Application.Model.Identity.Registration;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BugTracker.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AccountController : Controller
    {
        private readonly IIdentityService _identityService;
        private readonly IEmailService _emailService;

        public AccountController(IIdentityService identityService, IEmailService emailService)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegistrationModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await _identityService.Register(model);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
            var user = await _identityService.GetUserOrNullAsync(model.Email);
            var token = await _identityService.GenerateRegistrationEncodedToken(user.Id);
            var callbackLink = Url.ActionLink("ConfirmEmail", "Account", new { uid = user.Id, token = token });

            var mailResult = await _emailService.SendRegistrationMail(model.Email, callbackLink);
            if (mailResult == false)
            {
                throw new Exception();
            }
            return RedirectToAction("ConfirmEmail", new { email = model.Email });

        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AuthenticationModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await _identityService.UserEmailExist(model.Email))
            {
                var result = await _identityService.AuthenticateAsync(model);

                if (result.Succeeded)
                {
                    ModelState.Clear();
                    return RedirectToAction("Index", "Home", new { area = "Tracker" });
                }
                if (result.IsNotAllowed)
                {
                    ModelState.AddModelError("", "Please confirm your account via the Email we sent to you.");
                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid Credential");
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _identityService.SignOutAsync();
            return RedirectToAction("index", "home", new { area = "" });
        }

        public async Task<IActionResult> ConfirmEmail(string uid, string token, string email)
        {
            EmailConfirmationModel model = new EmailConfirmationModel
            {
                Email = email,
                IsSent = true
            };

            if (!string.IsNullOrEmpty(uid) & !string.IsNullOrEmpty(token))
            {
                token = FormatToken(token);
                var result = await _identityService.ConfirmEmail(uid, token);
                if (result.Succeeded)
                {
                    model.IsVerified = true;
                }
            }

            return View(model);
        }


        public ViewResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<ViewResult> ForgotPassword(ForgotPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _identityService.GetUserOrNullAsync(model.Email);

                if (user != null)
                {
                    var token = await _identityService.GeneratePasswordForgottenMailToken(user.Email);
                    var callbackLink = Url.ActionLink("ResetPassword", "Account", new { uid = user.Id, token = token });

                    await _emailService.SendForgotPasswordMail(user.Email, callbackLink);
                }
                ModelState.Clear();
                model.EmailSent = true;
            }
            return View(model);
        }

        public ViewResult ResetPassword(string uid, string token)
        {
            var model = new ResetPasswordModel()
            {
                Uid = uid,
                Token = token
            };

            return View(model);
        }

        [HttpPost]
        public async Task<ViewResult> ResetPassword(ResetPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                model.Token = FormatToken(model.Token);
                var result = await _identityService.ResetPassword(model);

                if (result.Succeeded)
                {
                    ModelState.Clear();
                    model.IsSuccess = true;
                    return View(model);
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        private string FormatToken(string token)
        {
            token = token.Replace(' ', '+');
            return token;
        }
    }
}
