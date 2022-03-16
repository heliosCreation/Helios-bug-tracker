using BugTracker.Application.Contracts.Identity;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
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
            Roles = _httpContextAccessor.HttpContext?.User.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).ToList();
        }
        public string UserId { get; set; }
        public List<string> Roles { get; set; }
    }
}
