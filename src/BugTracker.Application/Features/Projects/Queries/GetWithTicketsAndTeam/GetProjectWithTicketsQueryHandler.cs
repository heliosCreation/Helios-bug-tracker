using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Queries.GetWithTickets
{
    public class GetProjectWithTicketsAndTeamQueryHandler : IRequestHandler<GetProjectWithTicketsAndTeamQuery, ApiResponse<ProjectWithTicketsAndTeamVm>>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public GetProjectWithTicketsAndTeamQueryHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<ApiResponse<ProjectWithTicketsAndTeamVm>> Handle(GetProjectWithTicketsAndTeamQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<ProjectWithTicketsAndTeamVm>();
            var project = await _projectRepository.GetByIdAsync(request.Id);
            if (project == null)
            {
                return response.setNotFoundResponse($"Project with id {request.Id} was not found");
            }
            response.Data = _mapper.Map<ProjectWithTicketsAndTeamVm>(project);
            return response;
        }
    }
}
