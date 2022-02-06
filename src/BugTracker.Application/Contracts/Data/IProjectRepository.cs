using BugTracker.Application.Dto;
using BugTracker.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Data
{
    public interface IProjectRepository : IAsyncRepository<Project>
    {
        Task<ICollection<ProjectWithTeamDto>> ListAllWithTeam();
        Task<Project> AddProjectAsync(Project entity, ICollection<string> teamIds);
        Task<bool> NameIsUnique(string name);
    }
}
