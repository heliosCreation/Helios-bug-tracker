using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Domain.Common
{
    public class AuditableEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? LastModifiedBy { get; set; }

    }
}
