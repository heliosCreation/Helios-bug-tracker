using BugTracker.Application.Contracts.Infrastructure.Mail;
using BugTracker.Application.Model.Mail;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BugTracker.Infrastructure.Mail
{
    public class EmailService : IEmailService
    {
        private const string accountTemplatePath = @"wwwroot/Templates/Account/{0}.html";
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
            var kvp = new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("{{ConfirmationLink}}", url) };
            string body = UpdatePlaceHolders(GetAccountEmailBody("SignupConfirmation"), kvp);

            var email = new Email
            {
                To = address,
                Subject = "Email confirmation",
                Body = body
            };
            return await SendMail(email);
        }

        public async Task SendForgotPasswordMail(string address, string url)
        {
            var kvp = new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("{{ConfirmationLink}}", url) };
            string body = UpdatePlaceHolders(GetAccountEmailBody("ForgetPassword"), kvp);

            var email = new Email
            {
                To = address,
                Subject = "Reset your password",
                Body = body
            };
            var result = await SendMail(email);
        }



        private string GetAccountEmailBody(string templateName)
        {
            var body = File.ReadAllText(string.Format(accountTemplatePath, templateName));
            return body;
        }

        private string UpdatePlaceHolders(string text, List<KeyValuePair<string,string>> keyValuePairs)
        {
            if (!string.IsNullOrEmpty(text) && keyValuePairs != null)
            {
                foreach (var placeHolder in keyValuePairs)
                {
                    if (text.Contains(placeHolder.Key))
                    {
                        text = text.Replace(placeHolder.Key, placeHolder.Value);
                    }
                }
            }

            return text;
        }

    }

}
