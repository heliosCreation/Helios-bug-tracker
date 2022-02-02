using BugTracker.Application.Responses;
using MediatR;
using System;

namespace BugTracker.Application.Features.Projects.Commands.Delete
{
    public class DeleteProjectCommand : IRequest<ApiResponse<object>>
    {
        public Guid Id { get; set; }
    }
}
