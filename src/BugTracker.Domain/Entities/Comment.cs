using BugTracker.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Domain.Entities
{
    public class Comment : AuditableEntity
    {
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
        public Guid ProjectId { get; set; }
        public string Message { get; set; }
    }
}
