using System;

namespace BugTracker.Application.Dto.Comments
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public string User { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
