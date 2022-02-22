using BugTracker.Application.Features.Tickets;
using BugTracker.Application.Model.Pagination;
using System;
using System.Collections.Generic;

namespace BugTracker.Application.ViewModel
{
    public class ProjectWithTicketVm
    {
        public ProjectWithTicketVm(Guid id, string name, List<TicketVm> tickets, Pager pager)
        {
            Id = id;
            Name = name;
            Tickets = tickets;
            Pager = pager;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<TicketVm> Tickets { get; set; } = new List<TicketVm>();
        public Pager Pager { get; set; }
    }
}
