using BugTracker.Application.Contracts.Infrastructure.Mail;
using BugTracker.Application.Model.Mail;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Infrastructure.Mail
{
    public class EmailService : IEmailService
    {
        public EmailSettings _emailSettings { get; }

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task<bool> SendMail(Email email)
        {
            var client = new SendGridClient(_emailSettings.MailApiKey);

            var subject = email.Subject;
            var to = new EmailAddress(email.To);
            var body = email.Body;

            var from = new EmailAddress
            {
                Email = _emailSettings.FromAddress,
                Name = _emailSettings.FromName
            };

            var sendGridMessage = MailHelper.CreateSingleEmail(from, to, subject, body, body);
            var response = await client.SendEmailAsync(sendGridMessage);

            return response.StatusCode == System.Net.HttpStatusCode.Accepted || response.StatusCode == System.Net.HttpStatusCode.OK;
        }

        public async Task<bool> SendRegistrationMail(string address, string url)
        {
            var email = new Email
            {
                To = address,
                Subject = "Email confirmation",
                Body = $"<p> To finalize your registration click <a href=\"{url}\">here</a>. :) </p>"
            };
            return await SendMail(email);
        }

        public async Task SendForgotPasswordMail(string address, string url)
        {
            var email = new Email
            {
                To = address,
                Subject = "Forgot password",
                Body = $"<p> To reset your password click <a href=\"{url}\">here</a>.</p>"
            };
            var result = await SendMail(email);
        }


    }

}
