using System;

namespace BugTracker.Application.Dto.Comments
{
    public class CommentDto
    {
        public string Message { get; set; }
        public string User { get; set; }
        public Guid TicketId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
