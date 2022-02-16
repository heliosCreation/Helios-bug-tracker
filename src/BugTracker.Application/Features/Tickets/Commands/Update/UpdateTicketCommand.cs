using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;

namespace BugTracker.Application.Features.Tickets.Commands.Update
{
    public class UpdateTicketCommand : IRequest<ApiResponse<object>>
    {
        public UpdateTicketCommand()
        {

        }
        public UpdateTicketCommand(Guid ticketId)
        {
            TicketId = ticketId;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int EstimatedAmountOfHours { get; set; }
        public Guid PriorityId { get; set; }
        public Guid TypeId { get; set; }
        public Guid StatusId { get; set; }

        public ICollection<Guid> Team { get; set; } = new List<Guid>();
        public Guid TicketId { get; }
    }
}
