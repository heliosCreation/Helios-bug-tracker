using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Responses;
using BugTracker.Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Commands.Update
{
    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, ApiResponse<object>>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;
        private readonly ILoggedInUserService _loggedInuserService;

        public UpdateProjectCommandHandler(IProjectRepository projectRepository, IMapper mapper, ILoggedInUserService loggedInuserService)
        {
            _projectRepository = projectRepository ?? throw new System.ArgumentNullException(nameof(projectRepository));
            _mapper = mapper ?? throw new System.ArgumentNullException(nameof(mapper));
            _loggedInuserService = loggedInuserService ?? throw new System.ArgumentNullException(nameof(loggedInuserService));
        }
        public async Task<ApiResponse<object>> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<object>();
            var project = await _projectRepository.GetByIdAsync(request.Id);
            if (project == null)
            {
                return response.setNotFoundResponse($"Project with id {request.Id} was not found");
            }
            _mapper.Map(request, project, typeof(UpdateProjectCommand), typeof(Project));

            bool isAdmin = _loggedInuserService.Roles.Any(str => str.Contains("Admin"));
            await _projectRepository.UpdateProjectAsync(project, request.Team, isAdmin );

            return response;
        }
    }
}
