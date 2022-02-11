using BugTracker.Application.Dto.TicketConfiguration;
using System.Collections.Generic;

namespace BugTracker.Application.ViewModel
{
    public class TicketConfigurationEntitiesViewModel
    {
        public List<StatusDto> Statuses { get; set; } = new List<StatusDto>();
        public List<PriorityDto> Priorities { get; set; } = new List<PriorityDto>();
        public List<TypeDto> Types { get; set; } = new List<TypeDto>();
    }
}
