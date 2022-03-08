using BugTracker.Application.Dto.UserManagement;
using BugTracker.Application.Responses;
using MediatR;

namespace BugTracker.Application.Features.UserManagement.GetUserWithRoles
{
    public class GetUserWithRoleQuery : IRequest<ApiResponse<UserWithRoleDto>>
    {
        public GetUserWithRoleQuery(string uid)
        {
            UserId = uid;
        }

        public string UserId { get; }
    }
}
