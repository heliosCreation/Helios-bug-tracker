using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Queries.Get
{
    public class GetProjectQueryHandler : IRequestHandler<GetProjectQuery, ApiResponse<ProjectVm>>
    {
        private readonly IMapper _mapper;
        private readonly IProjectRepository _projectRepository;

        public GetProjectQueryHandler(IMapper mapper, IProjectRepository projectRepository)
        {
            _mapper = mapper;
            _projectRepository = projectRepository;
        }
        public async Task<ApiResponse<ProjectVm>> Handle(GetProjectQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<ProjectVm>();
            var project = await _projectRepository.GetByIdAsync(request.Id);

            if (project == null)
            {
                response.setNotFoundResponse($"The project with Id {request.Id} was not found");
                return response;
            }

            response.Data = _mapper.Map<ProjectVm>(project);
            return response;
        }
    }
}
