using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Model.Pagination;
using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Tickets.Queries.GetProjectTickets
{
    public class GetProjectTicketsQueryHandler : IRequestHandler<GetProjectTicketsQuery, ApiResponse<ProjectWithTicketVm>>
    {
        private readonly IMapper _mapper;
        private readonly ITicketRepository _ticketRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly IIdentityService _identityService;
        private readonly ITicketConfigurationRepository _ticketConfigurationRepository;

        public GetProjectTicketsQueryHandler(
            IMapper mapper,
            ITicketRepository ticketRepository,
            IProjectRepository projectRepository,
            IIdentityService identityService,
            ITicketConfigurationRepository ticketConfigurationRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
            _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _ticketConfigurationRepository = ticketConfigurationRepository ?? throw new ArgumentNullException(nameof(ticketConfigurationRepository));
        }

        public async Task<ApiResponse<ProjectWithTicketVm>> Handle(GetProjectTicketsQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<ProjectWithTicketVm>();

            var setCount = (await _ticketRepository.ListAllAsync()).Count();
            var project = await _projectRepository.GetByIdAsync(request.ProjectId);
            var tickets = (await _ticketRepository.GetTicketsByProject(request.ProjectId,request.Page,request.ItemPerPage, request.SearchString)).ToList();
            var pager = new Pager(setCount, request.Page, request.ItemPerPage) {RelatedId = project.Id };

            response.Data = new ProjectWithTicketVm(project.Id, project.Name, _mapper.Map<List<TicketVm>>(tickets), pager);

            for (int i = 0; i < response.Data.Tickets.Count(); i++)
            {
                var target = response.Data.Tickets[i];
                target.Author = await _identityService.GetUserNameById(tickets[i].CreatedBy.ToString());
                target.Priority = tickets[i].Priority.Name;
                target.Status = tickets[i].Status.Name;
                target.Type = tickets[i].Type.Name;
            }
            return response; 
        }
    }
}
