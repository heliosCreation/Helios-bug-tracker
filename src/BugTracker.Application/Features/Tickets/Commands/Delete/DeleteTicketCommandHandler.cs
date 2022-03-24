using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Commands.Delete
{
    public class DeleteTicketCommandHandler : IRequestHandler<DeleteTicketCommand, ApiResponse<object>>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly IProjectRepository _projectRepository;

        public DeleteTicketCommandHandler(ITicketRepository ticketRepository, ILoggedInUserService loggedInUserService, IProjectRepository projectRepository)
        {
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
            _loggedInUserService = loggedInUserService ?? throw new ArgumentNullException(nameof(loggedInUserService));
            _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
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

        private async Task<bool> IsAllowedToAccessTickets(ApiResponse<object> response, Guid ticketId)
        {
            var isAdmin = _loggedInUserService.Roles.Contains("Admin");
            var isProjectManager = _loggedInUserService.Roles.Any(str => str == "Project Manager");
            var isSubmitter = _loggedInUserService.Roles.Any(str => str == "Submitter");

            if (isAdmin)
            {
                return true;
            }
            else if (isProjectManager || isSubmitter)
            {
                var projectId = await _projectRepository.GetProjectIdByTicketId(ticketId);
                return await _projectRepository.UserBelongsToProjectTeam(_loggedInUserService.UserId, projectId);
            }


            return await _ticketRepository.UserBelongsToTicketTeam(_loggedInUserService.UserId, ticketId);
        }
    }
}
