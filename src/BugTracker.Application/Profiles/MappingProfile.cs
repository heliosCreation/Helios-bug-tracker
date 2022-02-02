using AutoMapper;
using BugTracker.Application.Features.Projects;
using BugTracker.Application.Features.Projects.Commands.Create;
using BugTracker.Domain.Entities;
using System.Linq;

namespace BugTracker.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProjectCommand, Project>();
            CreateMap<Project, ProjectVm>()
                .ForMember(dest => dest.TeamNames, opt => opt.MapFrom(src => src.Team.Select(t => t.UserName)));
        }
    }
}
