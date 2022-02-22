using BugTracker.Application.Features.Tickets;
using System;
using System.Collections.Generic;

namespace BugTracker.Application.Features.Projects
{
    public class ProjectWithTicketsAndTeamVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<string> TeamNames { get; set; }

        public ICollection<TicketVm> Tickets { get; set; }
    }
}
