using System.ComponentModel.DataAnnotations;

namespace BugTracker.Application.Model.Identity.Registration
{
    public class RegistrationModel
    {
        [Required]
        [EmailAddress]
        [MaxLength(120)]
        public string Email { get; set; }

        //[RegularExpression(@"^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8,20}$",
        //            ErrorMessage = "Password is not valid, it must be between 8 - 20 characters and contain a number and a capital letter")]
        //[DataType(DataType.Password)]
        [Required, DataType(DataType.Password), Display(Name = "Password")]

        public string Password { get; set; }

        [Required, DataType(DataType.Password), Display(Name = "Confirm your Password"), Compare("Password")]

        public string ConfirmationPassword { get; set; }
    }
}
