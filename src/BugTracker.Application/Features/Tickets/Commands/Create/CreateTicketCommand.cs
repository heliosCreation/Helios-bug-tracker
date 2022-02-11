using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;

namespace BugTracker.Application.Features.Tickets.Commands.Create
{
    public class CreateTicketCommand : IRequest<ApiResponse<IdResponse>>
    {
        public CreateTicketCommand(Guid projectId)
        {
            ProjectId = projectId;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Guid PriorityId { get; set; }
        public Guid TypeId { get; set; }
        public Guid StatusId { get; set; }

        public ICollection<Guid> Team { get; set; } = new List<Guid>();
        public Guid ProjectId { get; set; }

    }
}
