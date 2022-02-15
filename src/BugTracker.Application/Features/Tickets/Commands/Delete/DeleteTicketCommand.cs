using BugTracker.Application.Responses;
using MediatR;
using System;

namespace BugTracker.Application.Features.Tickets.Commands.Delete
{
    public class DeleteTicketCommand : IRequest<ApiResponse<object>>
    {
        public DeleteTicketCommand()
        {

        }
        public DeleteTicketCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
