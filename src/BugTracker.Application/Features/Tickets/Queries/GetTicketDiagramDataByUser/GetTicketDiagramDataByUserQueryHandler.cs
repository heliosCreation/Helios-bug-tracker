using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using BugTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Queries.GetTicketDiagramDataByUser
{
    public class GetTicketDiagramDataByUserQueryHandler : IRequestHandler<GetTicketDiagramDataByUserQuery, ApiResponse<TicketDiagramDataModel>>
    {
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly ITicketRepository _ticketRepository;

        public GetTicketDiagramDataByUserQueryHandler(ILoggedInUserService loggedInUserService, ITicketRepository ticketRepository)
        {
            _loggedInUserService = loggedInUserService ?? throw new ArgumentNullException(nameof(loggedInUserService));
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
        }

        public Task<ApiResponse<TicketDiagramDataModel>> Handle(GetTicketDiagramDataByUserQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<TicketDiagramDataModel>();
            response.Data = new TicketDiagramDataModel();


        }

        private async Task<IEnumerable<Ticket>> GetAppropriateTicketSet()
        {

            if (_loggedInUserService.Roles.Any(str => str.Contains("Admin")))
            {
                return await _ticketRepository.ListAllAsync(request.Page, request.Search);
            }

            else if (_loggedInUserService.Roles.Any(str => str.Contains("Project Manager")))
            {
                return await _ticketRepository.GetProjectManagerTickets(_loggedInUserService.UserId, request.Page, request.Search);
            }
            else if (_loggedInUserService.Roles.Any(str => str.Contains("Project Manager"))
            {

            }

            return await _ticketRepository.GetTicketsByUser(_loggedInUserService.UserId, request.Page, request.Search, request.ShowOnlyCreated);

        }
    }
}
