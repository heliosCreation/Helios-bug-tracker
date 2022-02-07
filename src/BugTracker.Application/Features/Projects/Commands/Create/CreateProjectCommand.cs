using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;

namespace BugTracker.Application.Features.Projects.Commands.Create
{
    public class CreateProjectCommand : IRequest<ApiResponse<ProjectVm>>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Guid> Team { get; set; } = new List<Guid>();
    }
}
