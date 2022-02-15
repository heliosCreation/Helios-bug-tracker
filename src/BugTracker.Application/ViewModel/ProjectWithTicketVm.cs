using BugTracker.Application.Features.Tickets;
using System;
using System.Collections.Generic;

namespace BugTracker.Application.ViewModel
{
    public class ProjectWithTicketVm
    {
        public ProjectWithTicketVm(Guid id, string name, List<TicketVm> tickets)
        {
            Id = id;
            Name = name;
            Tickets = tickets;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<TicketVm> Tickets { get; set; } = new List<TicketVm>();
    }
}
