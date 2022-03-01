using BugTracker.Application.Dto.Comments;
using BugTracker.Application.Responses;
using MediatR;
using System;

namespace BugTracker.Application.Features.Comments.Commands.Create
{
    public class CreateCommentCommand : IRequest<ApiResponse<CommentDto>>
    {
        public CreateCommentCommand()
        {

        }
        public CreateCommentCommand(string message, Guid ticketId)
        {
            Message = message;
            TicketId = ticketId;
        }

        public string Message { get; set; }
        public Guid TicketId { get; set; }
    }
}
