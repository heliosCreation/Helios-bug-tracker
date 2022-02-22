using BugTracker.Domain.Identity;
using System;

namespace BugTracker.Domain.Entities
{
    public class TicketsTeamMembers
    {
        public Ticket Ticket { get; set; }
        public Guid TicketId { get; set; }

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}
