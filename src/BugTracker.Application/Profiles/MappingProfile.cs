using AutoMapper;
using BugTracker.Application.Features.Projects;
using BugTracker.Application.Features.Projects.Commands.Create;
using BugTracker.Application.Features.Projects.Commands.Update;
using BugTracker.Application.Features.Projects.Queries;
using BugTracker.Application.ViewModel;
using BugTracker.Domain.Entities;
using BugTracker.Domain.Identity;
using System.Linq;

namespace BugTracker.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region project
            CreateMap<CreateProjectCommand, Project>();
            CreateMap<UpdateProjectCommand, Project>();
            CreateMap<Project, ProjectVm>()
                .ForMember(dest => dest.TeamNames, opt => opt.MapFrom(src => src.Team.Select(t => t.UserName)));
            CreateMap<Project, ProjectWithTicketsVm>();
            #endregion

            #region user
            CreateMap<ApplicationUser, UserViewModel>();
            #endregion
        }
    }
}
