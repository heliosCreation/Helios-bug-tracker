using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Responses;
using BugTracker.Domain.Entities;
using BugTracker.Domain.Identity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Commands.Create
{

    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, ApiResponse<ProjectVm>>
    {
        private readonly IMapper _mapper;
        private readonly IProjectRepository _projectRepository;

        public CreateProjectCommandHandler(
            IMapper mapper,
            IProjectRepository categoryRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _projectRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        public async Task<ApiResponse<ProjectVm>> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<ProjectVm>();

            var project = new Project { Name = request.Name, Description = request.Description };
            foreach (var id in request.Team)
            {
                //project.Team.Add(new ApplicationUser() { Id = id.ToString()});
            }

            var createdProject = await _projectRepository.AddAsync(project);
            response.Data = _mapper.Map<ProjectVm>(createdProject);
            return response;
        }
    }
}
