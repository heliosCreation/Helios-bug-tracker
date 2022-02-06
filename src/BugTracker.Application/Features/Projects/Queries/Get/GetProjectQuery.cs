using BugTracker.Application.Responses;
using MediatR;
using System;

namespace BugTracker.Application.Features.Projects.Queries.Get
{
    public class GetProjectQuery : IRequest<ApiResponse<ProjectWithTicketsVm>>
    {
        public Guid Id { get; set; }
    }
}
