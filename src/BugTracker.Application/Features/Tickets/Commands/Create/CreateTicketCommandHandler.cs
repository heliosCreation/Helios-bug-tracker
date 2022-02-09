using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Responses;
using BugTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Commands.Create
{
    public class CreateTicketCommandHandler : IRequestHandler<CreateTicketCommand, ApiResponse<IdResponse>>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public CreateTicketCommandHandler(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ApiResponse<IdResponse>> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<IdResponse>();

            var ticket = _mapper.Map<Ticket>(request);
            var teamIds = request.Team.Select(t => t.ToString()).ToList();

            var createdProject = await _ticketRepository.AddTicketAsync(ticket, teamIds);
            response.Data = new IdResponse(createdProject.Id);
            return response;
        }
    }
}
