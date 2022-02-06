using BugTracker.Application.Features.Tickets.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Queries
{
    public class ProjectWithTicketsVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<string> TeamNames { get; set; }

        public ICollection<TicketVm> Tickets { get; set; }
    }
}
