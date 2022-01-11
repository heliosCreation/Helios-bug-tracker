using System.ComponentModel.DataAnnotations;

namespace BugTracker.Application.Model.Identity.ConfirmationAndReset
{
    public class ForgotPasswordModel
    {
        [Required(ErrorMessage = "You must provide your email adress"), EmailAddress]
        public string Email { get; set; }
        public bool EmailSent
        {
            get; set;
        }
    }
}
