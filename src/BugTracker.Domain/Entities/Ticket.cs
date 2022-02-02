using BugTracker.Application.Model.Identity;
using BugTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Domain.Entities
{
    public class Ticket : AuditableEntity
    {
        public Guid Priority { get; set; }
        public Guid Status { get; set; }
        public Guid Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EstimatedAmountOfHours { get; set; }


        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
        public Guid ProjectId { get; set; }


        [ForeignKey("CreatorId")]
        public ApplicationUser Creator { get; set; }
        public Guid CreatorId { get; set; }

        public ICollection<ApplicationUser> Team { get; set; }


    }
}
