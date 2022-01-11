using Microsoft.AspNetCore.Identity;

namespace BugTracker.Application.Model.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
