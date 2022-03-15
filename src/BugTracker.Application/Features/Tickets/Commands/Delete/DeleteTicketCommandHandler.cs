using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
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
        private readonly ILoggedInUserService _loggedInUserService;

        public DeleteTicketCommandHandler(ITicketRepository ticketRepository, ILoggedInUserService loggedInUserService)
        {
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
            _loggedInUserService = loggedInUserService ?? throw new ArgumentNullException(nameof(loggedInUserService));
        }
        public async Task<ApiResponse<object>> Handle(DeleteTicketCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<object>();

            if (!await IsAllowedToAccessTickets(response, request.Id))
            {
                return response;
            }
            var ticket = await _ticketRepository.GetByIdAsync(request.Id);
            if (ticket == null)
            {
                return response.setNotFoundResponse($"Ticket with Id {request.Id} could not be Found");
            }

            await _ticketRepository.DeleteAsync(ticket);
            return response;
        }

        private async Task<bool> IsAllowedToAccessTickets(ApiResponse<object> response, Guid projectId)
        {
            var belongsToTeam = await _ticketRepository.UserBelongsToTicketTeam(_loggedInUserService.UserId, projectId);
            var isAdmin = _loggedInUserService.Roles.Contains("Admin");
            if (!belongsToTeam && !isAdmin)
            {
                response.SetUnhautorizedResponse();
                return false;
            }

            return true;
        }
    }
}
