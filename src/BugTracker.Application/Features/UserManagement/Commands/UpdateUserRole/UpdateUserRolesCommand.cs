using BugTracker.Application.Responses;
using MediatR;

namespace BugTracker.Application.Features.UserManagement.Commands.UpdateUserRole
{
    public class UpdateUserRolesCommand : IRequest<ApiResponse<object>>
    {
        public UpdateUserRolesCommand()
        {

        }
        public UpdateUserRolesCommand(string userId, string roleId)
        {
            UserId = userId;
            RoleId = roleId;
        }

        public string UserId { get; set; }
        public string RoleId { get; set; }
    }
}
