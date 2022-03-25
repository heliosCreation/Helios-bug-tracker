namespace BugTracker.Application.Dto.Tickets.Diagram
{
    public class TicketByStatusDto
    {
        public int NewCount { get; set; }
        public int OpenCount { get; set; }
        public int InProgressCount { get; set; }
        public int ResolvedCount { get; set; }
    }
}
