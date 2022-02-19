using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;

namespace BugTracker.Application.Features.ProjectTeam.Queries.GetAllAccessibleMembers
{
    public class GetAllAccessibleProjectMembersQuery : IRequest<ApiResponse<UserViewModel>>
    {
    }
}
