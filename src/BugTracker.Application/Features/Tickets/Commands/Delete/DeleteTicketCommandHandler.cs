using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Commands.Delete
{
    public class DeleteTicketCommandHandler : IRequestHandler<DeleteTicketCommand, ApiResponse<object>>
    {
        private readonly ITicketRepository _ticketRepository;

        public DeleteTicketCommandHandler(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
        }
        public async Task<ApiResponse<object>> Handle(DeleteTicketCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<object>();
            var ticket = await _ticketRepository.GetByIdAsync(request.Id);
            if (ticket == null)
            {
                return response.setNotFoundResponse($"Ticket with Id {request.Id} could not be Found");
            }

            await _ticketRepository.DeleteAsync(ticket);
            return response;
        }
    }
}
