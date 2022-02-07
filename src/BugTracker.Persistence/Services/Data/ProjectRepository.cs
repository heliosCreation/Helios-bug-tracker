using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Dto;
using BugTracker.Application.Dto.Projects;
using BugTracker.Domain.Entities;
using BugTracker.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Services.Data
{
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

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

        public async Task UpdateProjectAsync(Project entity, ICollection<string> teamIds)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            var dbProjectMemberIds = await _dbContext.
                                    ProjectTeamMembers.
                                    Where(ptm => ptm.ProjectId == entity.Id).
                                    Select(ptm => ptm.UserId).ToListAsync();

            foreach (var id in dbProjectMemberIds)
            {
                if (!teamIds.Contains(id))
                {
                     _dbContext.ProjectTeamMembers.Remove(new ProjectTeamMember { ProjectId = entity.Id, UserId = id });
                }
            }
            foreach (var id in teamIds)
            {
                if (!dbProjectMemberIds.Contains(id))
                {
                    await _dbContext.ProjectTeamMembers.AddAsync(new ProjectTeamMember { ProjectId = entity.Id, UserId = id });
                }
            }


            await _dbContext.SaveChangesAsync();
        }
        public async Task<ICollection<ProjectWithTeamDto>> ListAllWithTeam()
        {
            var response = new List<ProjectWithTeamDto>();
            var projects = await _dbContext.Projects.ToListAsync();

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

        public async Task<ICollection<string>> GetProjectTeamIds(Guid id)
        {
            return await _dbContext.ProjectTeamMembers.Where(ptm => ptm.ProjectId == id).Select(ptm => ptm.UserId).ToListAsync();
        }
        public async Task<bool> NameIsUnique(string name, bool isAnUpdate, Guid id)
        {
            if (isAnUpdate)
            {
                return await _dbContext.Projects.SingleOrDefaultAsync(p => p.Name == name && p.Id != id ) == null;
            }
            return await _dbContext.Projects.SingleOrDefaultAsync(p => p.Name == name) == null;
        }
    }
}
