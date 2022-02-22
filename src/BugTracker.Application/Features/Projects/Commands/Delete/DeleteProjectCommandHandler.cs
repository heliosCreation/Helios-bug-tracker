using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Commands.Delete
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, ApiResponse<object>>
    {
        private readonly IProjectRepository _projectRepository;

        public DeleteProjectCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
        }
        public async Task<ApiResponse<object>> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<object>();
            var project = await _projectRepository.GetByIdAsync(request.Id);
            if (project == null)
            {
                return response.setNotFoundResponse($"Project with Id {request.Id}could not be Found");
            }

            await _projectRepository.DeleteAsync(project);
            return response;
        }
    }
}
