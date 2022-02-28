using BugTracker.Application.Dto.Comments;
using BugTracker.Application.Responses;
using MediatR;
using System;

namespace BugTracker.Application.Features.Comments.Queries.GetAll
{
    public class GetAllCommentsQuery : IRequest<ApiResponse<CommentDto>>
    {
        public Guid TicketId { get; set; }

        public GetAllCommentsQuery(Guid ticketId)
        {
            TicketId = ticketId;
        }
    }
}
