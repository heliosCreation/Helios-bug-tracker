using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Responses;
using BugTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Commands.Update
{
    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, ApiResponse<object>>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public UpdateProjectCommandHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository ?? throw new System.ArgumentNullException(nameof(projectRepository));
            _mapper = mapper ?? throw new System.ArgumentNullException(nameof(mapper));
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
            await _projectRepository.UpdateProjectAsync(project, request.Team);

            return response;
        }
    }
}
