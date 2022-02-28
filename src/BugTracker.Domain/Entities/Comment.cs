using BugTracker.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Domain.Entities
{
    public class Comment : AuditableEntity
    {
        [ForeignKey("TicketId")]
        public Ticket Ticket { get; set; }
        public Guid TicketId { get; set; }
        public string Message { get; set; }
    }
}
