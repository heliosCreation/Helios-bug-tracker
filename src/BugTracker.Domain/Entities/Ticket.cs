using BugTracker.Domain.Common;
using BugTracker.Domain.Enums;
using BugTracker.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using Type = BugTracker.Domain.Enums.Type;

namespace BugTracker.Domain.Entities
{
    public class Ticket : AuditableEntity
    {
        public Priority Priority { get; set; }
        public Type Type { get; set; }
        public Status Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EstimatedAmountOfHours { get; set; }


        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
        public Guid ProjectId { get; set; }

        public ICollection<ApplicationUser> Team { get; set; }


    }
}
