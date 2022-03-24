using BugTracker.Application.Features.Tickets;
using BugTracker.Application.Model.Pagination;
using System.Collections.Generic;

namespace BugTracker.Application.ViewModel
{
    public class UserTicketsVm
    {
        public UserTicketsVm(List<TicketVm> tickets, Pager pager)
        {
            Tickets = tickets;
            Pager = pager;
        }
        public List<TicketVm> Tickets { get; set; }
        public Pager Pager { get; set; }
        public bool  ShowOnlyCreated { get; set; }
    }
}
