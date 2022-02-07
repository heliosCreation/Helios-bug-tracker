using BugTracker.Application.Responses;
using MediatR;
using System;

namespace BugTracker.Application.Features.Projects.Queries.Get
{
    public class GetProjectQuery : IRequest<ApiResponse<ProjectVm>>
    {
        public GetProjectQuery(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
