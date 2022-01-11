using System.ComponentModel.DataAnnotations;

namespace BugTracker.Application.Model.Identity.Authentication
{
    public class AuthenticationModel
    {
        [Required]
        [EmailAddress]
        [MaxLength(120)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(120)]
        public string Password { get; set; }
    }
}
