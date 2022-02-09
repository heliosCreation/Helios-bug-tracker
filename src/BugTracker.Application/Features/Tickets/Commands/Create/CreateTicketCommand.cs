using BugTracker.Application.Responses;
using BugTracker.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;

using Type = BugTracker.Domain.Enums.Type;

namespace BugTracker.Application.Features.Tickets.Commands.Create
{
    public class CreateTicketCommand : IRequest<ApiResponse<IdResponse>>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Priority Priority { get; set; }
        public Type Type { get; set; }
        public Status Status { get; set; }

        public ICollection<Guid> Team { get; set; } = new List<Guid>();

    }
}
