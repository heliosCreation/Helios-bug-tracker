using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Queries.GetProjectTickets
{
    public class GetProjectTicketsQueryHandler : IRequestHandler<GetProjectTicketsQuery, ApiResponse<TicketVm>>
    {
        private readonly IMapper _mapper;
        private readonly ITicketRepository _ticketRepository;
        private readonly IIdentityService _identityService;
        private readonly ITicketConfigurationRepository _ticketConfigurationRepository;

        public GetProjectTicketsQueryHandler(
            IMapper mapper,
            ITicketRepository ticketRepository,
            IIdentityService identityService,
            ITicketConfigurationRepository ticketConfigurationRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _ticketConfigurationRepository = ticketConfigurationRepository ?? throw new ArgumentNullException(nameof(ticketConfigurationRepository));
        }
        public async Task<ApiResponse<TicketVm>> Handle(GetProjectTicketsQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<TicketVm>();
            var tickets = (await _ticketRepository.GetTicketsByProject(request.ProjectId)).ToList();

            response.DataList = _mapper.Map<List<TicketVm>>(tickets.ToList());
            for (int i = 0; i < response.DataList.Count(); i++)
            {
                var target = response.DataList[i];
                target.Author = await _identityService.GetUserNameById(tickets[i].CreatedBy.ToString());
                target.Priority = tickets[i].Priority.Name;
                target.Status = tickets[i].Status.Name;
                target.Type = tickets[i].Type.Name;
            }
            return response; 
        }
    }
}
