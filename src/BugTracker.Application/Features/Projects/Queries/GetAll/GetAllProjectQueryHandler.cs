using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Queries.GetAll
{
    public class GetAllProjectQueryHandler : IRequestHandler<GetAllProjectQuery, ApiResponse<ProjectVm>>
    {
        private readonly IMapper _mapper;
        private readonly IProjectRepository _projectRepository;

        public GetAllProjectQueryHandler(
            IMapper mapper,
            IProjectRepository projectRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
        }

        public async Task<ApiResponse<ProjectVm>> Handle(GetAllProjectQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<ProjectVm>();
            var allProject = (await _projectRepository.ListAllAsync()).OrderBy(x => x.CreatedDate);
            response.DataList = _mapper.Map<List<ProjectVm>>(allProject);
            return response;
        }
    }
}
