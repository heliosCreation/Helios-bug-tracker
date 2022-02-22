using BugTracker.Application.Dto.TicketConfiguration;
using BugTracker.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace BugTracker.Application.Features.Tickets.Queries
{
    public class TicketWithTeamAndConfigurationVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public TypeDto Type { get; set; }
        public StatusDto Status { get; set; }
        public PriorityDto Priority { get; set; }
        public int EstimatedAmountOfHours { get; set; }

        public List<UserViewModel> TicketsTeamMembers { get; set; }

    }
}
