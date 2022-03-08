using AutoMapper;
using BugTracker.Application.Dto;
using BugTracker.Application.Dto.Audits;
using BugTracker.Application.Dto.Comments;
using BugTracker.Application.Dto.Projects;
using BugTracker.Application.Dto.TicketConfiguration;
using BugTracker.Application.Dto.UserManagement;
using BugTracker.Application.Features.Comments.Commands.Create;
using BugTracker.Application.Features.Projects;
using BugTracker.Application.Features.Projects.Commands.Create;
using BugTracker.Application.Features.Projects.Commands.Update;
using BugTracker.Application.Features.Projects.Queries;
using BugTracker.Application.Features.Tickets;
using BugTracker.Application.Features.Tickets.Commands.Create;
using BugTracker.Application.Features.Tickets.Commands.Update;
using BugTracker.Application.Features.Tickets.Queries;
using BugTracker.Application.Model.Auditing;
using BugTracker.Application.ViewModel;
using BugTracker.Domain.Common;
using BugTracker.Domain.Entities;
using BugTracker.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.Collections.Generic;
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
            CreateMap<ProjectWithTeamDto, ProjectVm>()
                .ForMember(dest => dest.TeamNames, opt => opt.MapFrom(src => src.Team.Select(teamMember => teamMember.UserName)))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Project.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Project.Description))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Project.Id));

            CreateMap<Project, ProjectVm>()
                .ForMember(dest => dest.TeamNames, opt => opt.MapFrom(src => src.Name));
            CreateMap<Project, ProjectWithTicketsAndTeamVm>();
            CreateMap<Project, ProjectWithTeamIdsVm>();
            #endregion

            #region user
            CreateMap<ApplicationUser, UserViewModel>();
            CreateMap<TicketsTeamMembers, UserViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UserId));
            #endregion

            #region comment
            CreateMap<Comment, CommentDto>()
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.CreatedBy.ToString()));
            CreateMap<CreateCommentCommand, Comment>();
            #endregion

            #region ticket
            CreateMap<CreateTicketCommand, Ticket>();
            CreateMap<UpdateTicketCommand, Ticket>();
            CreateMap<Ticket, TicketVm>().ReverseMap();
            CreateMap<Ticket, TicketWithTeamAndConfigurationVm>();
            CreateMap<Status, StatusDto>();
            CreateMap<Priority, PriorityDto>();
            CreateMap<Type, TypeDto>();
            #endregion

            #region audit
            CreateMap<Audit, AuditLogDto>()
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.AffectedColumns, opt => opt.MapFrom(src => JsonConvert.DeserializeObject<List<string>>(src.AffectedColumns)))
                .ForMember(dest => dest.OldValues, opt => opt.MapFrom(src => JsonConvert.DeserializeObject<Dictionary<string, string>>(src.OldValues)))
                .ForMember(dest => dest.NewValues, opt => opt.MapFrom(src => JsonConvert.DeserializeObject<Dictionary<string, string>>(src.NewValues)));
            #endregion

            #region roles
            CreateMap<IdentityRole, RoleDto>();
            #endregion
        }
    }
}
