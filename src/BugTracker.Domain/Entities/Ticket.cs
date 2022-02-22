using BugTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Domain.Entities
{
    public class Ticket : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int EstimatedAmountOfHours { get; set; }

        public ICollection<TicketsTeamMembers> TicketsTeamMembers { get; set; }

        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
        public Guid ProjectId { get; set; }

        [ForeignKey("PriorityId")]
        public Priority Priority { get; set; }
        public Guid PriorityId { get; set; }

        [ForeignKey("TypeId")]
        public Type Type { get; set; }
        public Guid TypeId { get; set; }

        [ForeignKey("StatusId")]
        public Status Status { get; set; }
        public Guid StatusId { get; set; }
    }
}
