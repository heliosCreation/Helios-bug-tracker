using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;

namespace BugTracker.Application.Features.Team.Queries.GetAllAccessibleMembers
{
    public class GetAllAccessibleMembersQuery : IRequest<ApiResponse<UserViewModel>>
    {
    }
}
