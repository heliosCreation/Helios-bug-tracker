using Microsoft.AspNetCore.Authorization;

namespace BugTracker.Application.Policies.NoDemoUser
{
    public class NoDemoUserRequirement : IAuthorizationRequirement
    {
    }
}
