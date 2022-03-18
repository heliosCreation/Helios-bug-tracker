using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Model.Pagination;
using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using BugTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Queries.GetTicketsByUser
{
    public class GetTicketByUserQueryHandler : IRequestHandler<GetTicketByUserQuery, ApiResponse<UserTicketsVm>>
    {
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly ITicketConfigurationRepository _ticketConfigurationRepository;
        private readonly ITicketRepository _ticketRepository;
        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;

        public GetTicketByUserQueryHandler(
            ILoggedInUserService loggedInUserService,
            ITicketConfigurationRepository ticketConfigurationRepository,
            ITicketRepository ticketRepository,
            IIdentityService identityService,
            IMapper mapper)
        {
            _loggedInUserService = loggedInUserService;
            _ticketConfigurationRepository = ticketConfigurationRepository ?? throw new ArgumentNullException(nameof(ticketConfigurationRepository));
            _ticketRepository = ticketRepository;
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _mapper = mapper;
        }
        public async Task<ApiResponse<UserTicketsVm>> Handle(GetTicketByUserQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<UserTicketsVm>();

            var setCount = await GetSetCount(request);
            var dbResult = await GetAppropriateTicketSet(request);
            var mappedResult = _mapper.Map<List<TicketVm>>(dbResult);
            var pager = new Pager(setCount, request.Page){};

            response.Data = new UserTicketsVm(mappedResult, pager);
            await AssignValueToHumanReadable(response, dbResult.ToList());
            return response;
        }

        private async Task AssignValueToHumanReadable(ApiResponse<UserTicketsVm> response, List<Ticket> tickets)
        {
            for (int i = 0; i < response.Data.Tickets.Count ; i++)
            {
                var target = response.Data.Tickets[i];
                target.Author = await _identityService.GetUserNameById(tickets[i].CreatedBy.ToString());
                target.Priority = tickets[i].Priority.Name;
                target.Status = tickets[i].Status.Name;
                target.Type = tickets[i].Type.Name;
            }
        }      
        private async Task<int> GetSetCount(GetTicketByUserQuery request)
        {
            var setCount = 0;
            if (request.ShowOnlyCreated)
            {
               return await _ticketRepository.GetUserCreatedTicketAmount(_loggedInUserService.UserId);
            }
            else if (_loggedInUserService.Roles.Contains("Admin"))
            {
                return (await _ticketRepository.ListAllAsync()).Count();
            }
            else
            {
                setCount = await _ticketRepository.CountUserAssignedTickets(_loggedInUserService.UserId);
            }

            return setCount;
        }
        
        private async Task<IEnumerable<Ticket>> GetAppropriateTicketSet(GetTicketByUserQuery request)
        {
            if (request.ShowOnlyCreated)
            {
                return await _ticketRepository.GetTicketsByUser(_loggedInUserService.UserId, request.Page, request.Search, request.ShowOnlyCreated);
            }

            if (_loggedInUserService.Roles.Contains("Admin"))
            {

                return await _ticketRepository.ListAllAsync(request.Page, request.Search);
            }

            return await _ticketRepository.GetTicketsByUser(_loggedInUserService.UserId, request.Page, request.Search, request.ShowOnlyCreated);

        }
    }
}
