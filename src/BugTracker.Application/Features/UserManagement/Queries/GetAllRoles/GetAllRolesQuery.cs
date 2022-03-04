using BugTracker.Application.Dto.UserManagement;
using BugTracker.Application.Responses;
using MediatR;

namespace BugTracker.Application.Features.UserManagement.GetAllRoles
{
    public class GetAllRolesQuery : IRequest<ApiResponse<RoleDto>>
    {
    }
}
