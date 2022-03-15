using System.Collections.Generic;

namespace BugTracker.Application.Contracts.Identity
{
    public interface ILoggedInUserService
    {
        public string UserId { get; set; }
        public List<string> Roles { get; set; }

    }
}
