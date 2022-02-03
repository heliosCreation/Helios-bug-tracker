using System;

namespace BugTracker.Application.Features.Tickets.Queries
{
    public class TicketVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
