namespace BugTracker.Application.Dto.Tickets.Diagram
{
    public class TicketByTypeDto
    {
        public int BugCount { get; set; }
        public int FeatureCount { get; set; }
        public int DocCount { get; set; }
        public int TrainingCount { get; set; }
    }
}
