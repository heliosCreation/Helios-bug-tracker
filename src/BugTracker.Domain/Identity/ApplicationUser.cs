using Microsoft.AspNetCore.Identity;

namespace BugTracker.Domain.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
