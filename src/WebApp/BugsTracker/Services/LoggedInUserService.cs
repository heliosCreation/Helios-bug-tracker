using BugTracker.Application.Contracts.Identity;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace BugTracker.Services
{
    public class LoggedInUserService : ILoggedInUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoggedInUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            UserId = _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public string UserId { get; set; }
    }
}
