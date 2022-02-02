using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;

namespace BugTracker.Application.Features.Projects.Commands.Update
{
    public class UpdateProjectCommand : IRequest<ApiResponse<object>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Guid> Team { get; set; }
    }
}
