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

namespace BugTracker.Application.Features.Tickets.Commands.Create
{
    public class CreateTicketCommandHandler : IRequestHandler<CreateTicketCommand, ApiResponse<IdResponse>>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly IMapper _mapper;

        public CreateTicketCommandHandler(ITicketRepository ticketRepository,
            IProjectRepository projectRepository,
            ILoggedInUserService loggedInUserService,
            IMapper mapper)
        {
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
            _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
            _loggedInUserService = loggedInUserService;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ApiResponse<IdResponse>> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<IdResponse>();
            if (! await IsAllowedToCreateTickets(request, request.ProjectId))
            {
                response.SetUnhautorizedResponse();
                return response;
            }

            var ticket = _mapper.Map<Ticket>(request);
            var teamIds = request.Team.Select(t => t.ToString()).ToList();

            var createdProject = await _ticketRepository.AddTicketAsync(ticket, teamIds);
            response.Data = new IdResponse(createdProject.Id);
            return response;
        }

        private async Task<bool> IsAllowedToCreateTickets(CreateTicketCommand request, Guid ticketId)
        {
            var isAdmin = _loggedInUserService.Roles.Contains("Admin");
            var isSubmitter = _loggedInUserService.Roles.Any(str => str == "Submitter");

            if (isAdmin)
            {
                return true;
            }
            else if (isSubmitter)
            {
                return await _projectRepository.UserBelongsToProjectTeam(_loggedInUserService.UserId, request.ProjectId);
            }


            return await _ticketRepository.UserBelongsToTicketTeam(_loggedInUserService.UserId, ticketId);
        }
    }
}
