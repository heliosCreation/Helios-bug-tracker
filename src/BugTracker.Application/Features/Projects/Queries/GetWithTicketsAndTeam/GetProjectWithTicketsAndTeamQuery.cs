using BugTracker.Application.Responses;
using MediatR;
using System;

namespace BugTracker.Application.Features.Projects.Queries.GetWithTickets
{
    public class GetProjectWithTicketsAndTeamQuery : IRequest<ApiResponse<ProjectWithTicketsAndTeamVm>>
    {
        public GetProjectWithTicketsAndTeamQuery(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
