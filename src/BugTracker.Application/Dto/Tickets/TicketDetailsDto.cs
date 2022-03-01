using BugTracker.Application.Dto.Audits;
using BugTracker.Application.Dto.Comments;
using BugTracker.Application.Features.Comments.Commands.Create;
using BugTracker.Application.Responses;
using System;
using System.Collections.Generic;

namespace BugTracker.Application.Dto.Tickets
{
    public class TicketDetailsDto
    {
        public Guid TicketId { get; set; }
        public List<AuditLogDto> History { get; set; }
        public ApiResponse<CommentDto> Comments { get; set; }
        public CreateCommentCommand CommentCommand { get; set; }
    }
}
