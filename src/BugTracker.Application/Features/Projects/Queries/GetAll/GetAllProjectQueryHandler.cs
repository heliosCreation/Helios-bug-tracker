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

namespace BugTracker.Application.Features.Projects.Queries.GetAll
{
    public class GetAllProjectQueryHandler : IRequestHandler<GetAllProjectQuery, ApiResponse<DashboardViewModel>>
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

        public async Task<ApiResponse<DashboardViewModel>> Handle(GetAllProjectQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<DashboardViewModel>();
            response.Data = new DashboardViewModel();
            var uid = _loggedInUserService.UserId;
            var roles = _loggedInUserService.Roles;
            bool containsAdmin = roles.Any(str => str.Contains("Admin"));
            var param = containsAdmin ? null : uid;

            var allProject = await _projectRepository.ListAll(param, request.Page);
            var projectCount = await _projectRepository.CountProject(param);
            response.Data.Projects = _mapper.Map<List<ProjectVm>>(allProject);
            response.Data.Pager = new Pager(projectCount, request.Page);
            return response;
        }
    }
}
