using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;

namespace BugTracker.Application.Features.UserManagement.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<ApiResponse<UserViewModel>>
    {
    }
}
