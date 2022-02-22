using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Responses;
using BugTracker.Domain.Entities;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Commands.Update
{
    public class UpdateTicketCommandHandler : IRequestHandler<UpdateTicketCommand, ApiResponse<object>>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public UpdateTicketCommandHandler(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<ApiResponse<object>> Handle(UpdateTicketCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<object>();
            var ticket = await _ticketRepository.GetByIdAsync(request.TicketId);
            if (ticket == null)
            {
                return response.setNotFoundResponse($"Ticket with Id: {request.TicketId} was not found.");
            }

            _mapper.Map(request, ticket, typeof(UpdateTicketCommand), typeof(Ticket));
            var updated = await _ticketRepository.UpdateTicketAsync(ticket, request.Team.Select(id => id.ToString()).ToList() );
            if (! updated)
            {
                return response.SetInternalServerErrorResponse();
            }

            return response;
        }
    }
}
