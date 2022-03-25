using BugTracker.Application.Dto.Tickets.Diagram;

namespace BugTracker.Application.ViewModel
{
    public class TicketDiagramDataModel
    {
        public TicketByTypeDto TypesCount { get; set; }
        public TicketByStatusDto StatusesCount { get; set; }
        public TicketByPriorityDto PrioritiesCount { get; set; }
    }
}
