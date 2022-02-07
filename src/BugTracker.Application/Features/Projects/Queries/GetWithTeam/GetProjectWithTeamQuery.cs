using BugTracker.Application.Responses;
using MediatR;
using System;

namespace BugTracker.Application.Features.Projects.Queries.GetWithTeam
{
    public class GetProjectWithTeamQuery : IRequest<ApiResponse<ProjectWithTeamIdsVm>>
    {
        public Guid Id { get; set; }
    }
}
