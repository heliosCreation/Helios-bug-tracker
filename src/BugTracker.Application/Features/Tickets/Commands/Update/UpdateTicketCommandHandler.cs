using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
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
        private readonly IProjectRepository _projectRepository;
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly IMapper _mapper;

        public UpdateTicketCommandHandler(ITicketRepository ticketRepository,
            IProjectRepository projectRepository,
            ILoggedInUserService loggedInUserService,
            IMapper mapper)
        {
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
            _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
            _loggedInUserService = loggedInUserService ?? throw new ArgumentNullException(nameof(loggedInUserService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<ApiResponse<object>> Handle(UpdateTicketCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<object>();

            if (!await IsAllowedToAccessTickets(response, request.TicketId))
            {
                return response.SetUnhautorizedResponse();
            }
            
            var ticket = await _ticketRepository.GetByIdAsync(request.TicketId);
            
            if (ticket == null)
            {
                return response.setNotFoundResponse($"Ticket with Id: {request.TicketId} was not found.");
            }
            
            DisableDevelopersInput(ticket, request);
            _mapper.Map(request, ticket, typeof(UpdateTicketCommand), typeof(Ticket));
            var updated = await _ticketRepository.UpdateTicketAsync(ticket, request.Team.Select(id => id.ToString()).ToList() );
            if (! updated)
            {
                return response.SetInternalServerErrorResponse();
            }
            
            return response;
        }

        private async Task<bool> IsAllowedToAccessTickets(ApiResponse<object> response, Guid ticketId)
        {
            var isAdmin = _loggedInUserService.Roles.Contains("Admin");
            var isProjectManager = _loggedInUserService.Roles.Any(str => str == "Project Manager");

            if (isAdmin)
            {
                return true;
            }
            else if (isProjectManager)
            {
                var projectId = await _projectRepository.GetProjectIdByTicketId(ticketId);
                return await _projectRepository.UserBelongsToProjectTeam(_loggedInUserService.UserId, projectId);
            }


            return await _ticketRepository.UserBelongsToTicketTeam(_loggedInUserService.UserId, ticketId);
        }
    
        private void DisableDevelopersInput(Ticket ticket, UpdateTicketCommand request)
        {
            if (_loggedInUserService.Roles.Any(str => str.ToLower().Contains("dev")))
            {
                request.Name = ticket.Name;
                request.Description = ticket.Description;
            }
        }
    }
}
