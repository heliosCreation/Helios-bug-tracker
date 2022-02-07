using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Queries.GetWithTeam
{
    public class GetProjectWithTeamQueryHandler : IRequestHandler<GetProjectWithTeamQuery, ApiResponse<ProjectWithTeamIdsVm>>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public GetProjectWithTeamQueryHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }
        public async Task<ApiResponse<ProjectWithTeamIdsVm>> Handle(GetProjectWithTeamQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<ProjectWithTeamIdsVm>();
            var project = await _projectRepository.GetByIdAsync(request.Id);
            if (project == null)
            {
                response.setNotFoundResponse($"The project with Id:{request.Id} could not be found");
                return response;
            }
            response.Data = _mapper.Map<ProjectWithTeamIdsVm>(project);
            response.Data.TeamIds = await _projectRepository.GetProjectTeamIds(request.Id);

            return response;
        }
    }
}
