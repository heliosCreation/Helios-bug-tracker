namespace BugTracker.Application.Dto.Tickets.Diagram
{
    public class TicketByPriorityDto
    {
        public int LowCount { get; set; }
        public int MediumCount { get; set; }
        public int HighCount { get; set; }
        public int ImmediateCount { get; set; }
    }
}
