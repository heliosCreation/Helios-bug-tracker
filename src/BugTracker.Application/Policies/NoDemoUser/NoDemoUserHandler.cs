using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BugTracker.Application.Policies.NoDemoUser
{
    public class NoDemoUserHandler : AuthorizationHandler<NoDemoUserRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, NoDemoUserRequirement requirement)
        {
            var claims = context.User.Claims.Where(c => c.Type == ClaimTypes.Role).Where(c => c.Value.Contains("Demo")).ToList();
            if (claims.Count > 0)
            {
                context.Fail();
            }
            else
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
