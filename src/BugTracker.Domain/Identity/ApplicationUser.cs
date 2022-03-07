using BugTracker.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BugTracker.Domain.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<ProjectTeamMember> ProjectTeamMembers { get; set; }
        public ICollection<TicketsTeamMembers> TicketsTeamMembers { get; set; }
    }
}
