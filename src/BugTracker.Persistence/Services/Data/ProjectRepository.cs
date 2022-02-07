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
        public async Task<bool> NameIsUnique(string name)
        {
            return await _dbContext.Projects.SingleOrDefaultAsync(p => p.Name == name) == null;
        }
    }
}
