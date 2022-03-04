using BugTracker.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace BugTracker.Application.Features.UserManagement.Commands.UpdateUserRole
{
    public class UpdateUserRolesCommand : IRequest<ApiResponse<object>>
    {
        public UpdateUserRolesCommand()
        {

        }
        public UpdateUserRolesCommand(string userId, List<string> roleIds)
        {
            UserId = userId;
            RoleIds = roleIds;
        }

        public string UserId { get; set; }
        public List<string> RoleIds { get; set; }
    }
}
