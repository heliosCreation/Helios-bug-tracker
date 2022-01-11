using System.ComponentModel.DataAnnotations;

namespace BugTracker.Application.Model.Identity.ConfirmationAndReset
{
    public class ResetPasswordModel
    {
        public string Uid { get; set; }
        public string Token { get; set; }

        [Required, DataType(DataType.Password), Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [Required, DataType(DataType.Password), Display(Name = "Confirm your Password"), Compare("NewPassword")]
        public string ConfirmPassword { get; set; }

        public bool IsSuccess { get; set; }
    }
}
