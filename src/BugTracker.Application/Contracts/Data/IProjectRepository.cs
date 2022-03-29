using BugTracker.Application.Dto.Projects;
using BugTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Data
{
    public interface IProjectRepository : IAsyncRepository<Project>
    {
        Task<ICollection<Project>> ListAll(string uid, int page);
        Task<Project> AddProjectAsync(Project entity, ICollection<string> teamIds);
        Task<bool> NameIsUnique(string name, bool isAnUpdate = false, Guid projectId = new Guid());
        Task<ICollection<string>> GetProjectTeamIds(Guid id);
        Task UpdateProjectAsync(Project entity, ICollection<string> teamIds, bool isAdmin);
        Task<bool> UserBelongsToProjectTeam(string uid, Guid projectId);
        Task<Guid> GetProjectIdByTicketId(Guid ticketId);
        Task<int> CountProject(string uid);
    }
}
