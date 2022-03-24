using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Dto.Projects;
using BugTracker.Domain.Entities;
using BugTracker.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Services.Data
{
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ProjectRepository(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager) 
            : base(dbContext)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        public async Task<Project> AddProjectAsync(Project entity, ICollection<string> teamIds)
        {

            await _dbContext.Projects.AddAsync(entity);
            foreach (var id in teamIds)
            {
                await _dbContext.ProjectTeamMembers.AddAsync(new ProjectTeamMember { ProjectId = entity.Id, UserId = id });
            }

            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task UpdateProjectAsync(Project entity, ICollection<string> teamIds, bool isAdmin)
        {
            var oldEntity = await _dbContext.Projects.FindAsync(entity.Id);
            _dbContext.Entry(oldEntity).CurrentValues.SetValues(entity);

            var dbProjectMembersId = await _dbContext.
                                    ProjectTeamMembers.
                                    Where(ptm => ptm.ProjectId == entity.Id).
                                    Select(ptm => ptm.UserId).ToListAsync();

            var relatedTicketsId = await _dbContext.Tickets.Where(t => t.ProjectId == entity.Id).Select(t => t.Id).ToListAsync();
            if (isAdmin)
            {
                await UpdateProjectTeam_Admin(dbProjectMembersId, teamIds.ToList(), relatedTicketsId, entity);
            }
            else
            {
                await UpdateProjectTeam_ProjectManager(dbProjectMembersId, teamIds.ToList(), relatedTicketsId, entity);
            }

            await _dbContext.SaveChangesAsync();
        }
        public async Task<ICollection<ProjectWithTeamDto>> ListAllWithTeam(string uid)
        {
            var response = new List<ProjectWithTeamDto>();
            var projects = new List<Project>();

            if (uid == null)
            {
                projects = await _dbContext.Projects.OrderBy(p => p.CreatedDate).ToListAsync();
            }
            else
            {
                var pids = await _dbContext.ProjectTeamMembers.Where(ptm => ptm.UserId == uid).Select(ptm => ptm.ProjectId).ToListAsync();
                projects = await _dbContext.Projects.Where(p => pids.Contains(p.Id)).OrderBy(p => p.CreatedDate).ToListAsync();
            }

            foreach (var project in projects)
            {
                var projectWithTeamDto = new ProjectWithTeamDto();
                projectWithTeamDto.Project = project;
                var projectTeamMembers = await _dbContext.ProjectTeamMembers.Where(ptm => ptm.ProjectId == project.Id).ToListAsync();
                foreach (var projectTeamMember in projectTeamMembers)
                {
                    var teamMember = await _dbContext.Users.FindAsync(projectTeamMember.UserId);
                    projectWithTeamDto.Team.Add(teamMember);
                }

                response.Add(projectWithTeamDto);
            }

            return response;
        }
        
        public async Task<Guid> GetProjectIdByTicketId(Guid ticketId)
        {
            return await _dbContext.Tickets.Where(t => t.Id == ticketId).Select(t => t.ProjectId).FirstOrDefaultAsync();
        }
        
        public async Task<bool> UserBelongsToProjectTeam(string uid, Guid projectId)
        {
            return await _dbContext.ProjectTeamMembers.AnyAsync(ptm => ptm.UserId == uid && ptm.ProjectId == projectId);
        }
        public async Task<ICollection<string>> GetProjectTeamIds(Guid id)
        {
            return await _dbContext.ProjectTeamMembers.Where(ptm => ptm.ProjectId == id).Select(ptm => ptm.UserId).ToListAsync();
        }
        public async Task<bool> NameIsUnique(string name, bool isAnUpdate, Guid id)
        {
            if (isAnUpdate)
            {
                return await _dbContext.Projects.SingleOrDefaultAsync(p => p.Name == name && p.Id != id) == null;
            }
            return await _dbContext.Projects.SingleOrDefaultAsync(p => p.Name == name) == null;
        }



        private async Task UpdateProjectTeam_ProjectManager(List<string> dbProjectMembersId, List<string> teamIds, List<Guid> relatedTicketsId, Project entity)
        {
            var projectManagers = (await _userManager.GetUsersInRoleAsync("Project Manager")).Select(u => u.Id).ToList();

            foreach (var dbProjectMemberId in dbProjectMembersId.Except(projectManagers).ToList())
            {
                if (!teamIds.Contains(dbProjectMemberId))
                {
                    //Remove project members
                    _dbContext.ProjectTeamMembers.Remove(new ProjectTeamMember { ProjectId = entity.Id, UserId = dbProjectMemberId });

                    //Remove related ticket team members if they are no longer project members.
                    foreach (var ticketId in relatedTicketsId)
                    {
                        var target = new TicketsTeamMembers() { TicketId = ticketId, UserId = dbProjectMemberId };
                        if (_dbContext.TicketsTeamMembers.Contains(target))
                        {
                            _dbContext.TicketsTeamMembers.Remove(target);
                        }
                    }
                }
            }
            foreach (var id in teamIds.Except(projectManagers).ToList())
            {
                if (!dbProjectMembersId.Contains(id))
                {
                    await _dbContext.ProjectTeamMembers.AddAsync(new ProjectTeamMember { ProjectId = entity.Id, UserId = id });
                }
            }

        }

        private async Task UpdateProjectTeam_Admin(List<string> dbProjectMembersId, List<string> teamIds, List<Guid> relatedTicketsId, Project entity)
        {
            foreach (var dbProjectMemberId in dbProjectMembersId)
            {
                if (!teamIds.Contains(dbProjectMemberId))
                {
                    //Remove project members
                    _dbContext.ProjectTeamMembers.Remove(new ProjectTeamMember { ProjectId = entity.Id, UserId = dbProjectMemberId });

                    //Remove related ticket team members if they are no longer project members.
                    foreach (var ticketId in relatedTicketsId)
                    {
                        var target = new TicketsTeamMembers() { TicketId = ticketId, UserId = dbProjectMemberId };
                        if (_dbContext.TicketsTeamMembers.Contains(target))
                        {
                            _dbContext.TicketsTeamMembers.Remove(target);
                        }
                    }
                }
            }
            foreach (var id in teamIds)
            {
                if (!dbProjectMembersId.Contains(id))
                {
                    await _dbContext.ProjectTeamMembers.AddAsync(new ProjectTeamMember { ProjectId = entity.Id, UserId = id });
                }
            }

        }
    }
}
