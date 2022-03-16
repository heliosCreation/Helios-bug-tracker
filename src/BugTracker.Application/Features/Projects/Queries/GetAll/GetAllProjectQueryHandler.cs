using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
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
        private readonly ILoggedInUserService _loggedInUserService;

        public GetAllProjectQueryHandler(
            IMapper mapper,
            IProjectRepository projectRepository,
            ILoggedInUserService loggedInUserService)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
            _loggedInUserService = loggedInUserService ?? throw new ArgumentNullException(nameof(loggedInUserService));
        }

        public async Task<ApiResponse<ProjectVm>> Handle(GetAllProjectQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<ProjectVm>();
            var uid = _loggedInUserService.UserId;
            var roles = _loggedInUserService.Roles;
            var param = roles.Contains("Admin") ? null : uid;

            var allProject = (await _projectRepository.ListAllWithTeam(param)).OrderByDescending(x => x.Project.CreatedDate);
            response.DataList = _mapper.Map<List<ProjectVm>>(allProject);
            return response;
        }
    }
}
