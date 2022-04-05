using BugTracker.Application.Model.Mail;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Infrastructure.Mail
{
    public interface IEmailService
    {
        Task SendForgotPasswordMail(string address, string url);
        Task<bool> SendMail(Email email);
        Task<bool> SendRegistrationMail(string address, string code);
        string tester();
    }
}
