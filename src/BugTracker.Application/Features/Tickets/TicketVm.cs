using System;

namespace BugTracker.Application.Features.Tickets
{
    public class TicketVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public int EstimatedAmountOfHours { get; set; }
        public string Project { get; set; }
    }
}
