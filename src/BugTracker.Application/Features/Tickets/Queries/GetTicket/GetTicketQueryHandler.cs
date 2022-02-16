using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Queries.GetTicket
{
    public class GetTicketQueryHandler : IRequestHandler<GetTicketQuery, ApiResponse<TicketWithTeamAndConfigurationVm>>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public GetTicketQueryHandler(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ApiResponse<TicketWithTeamAndConfigurationVm>> Handle(GetTicketQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<TicketWithTeamAndConfigurationVm>();
            var ticket = await _ticketRepository.GetTicketWithTeamAndConfiguration(request.Id);
            if (ticket == null)
            {
                return response.setNotFoundResponse($"Ticket with Id: {request.Id} could not be found");
            }

            var mappedTicket = _mapper.Map<TicketWithTeamAndConfigurationVm>(ticket);
            response.Data = mappedTicket;

            return response;
        }
    }
}
