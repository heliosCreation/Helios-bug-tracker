using BugTracker.Application.Responses;
using MediatR;
using System;

namespace BugTracker.Application.Features.Projects.Queries.GetWithTickets
{
    public class GetProjectWithTicketsQuery : IRequest<ApiResponse<ProjectWithTicketsVm>>
    {
        public Guid Id { get; set; }
    }
}
