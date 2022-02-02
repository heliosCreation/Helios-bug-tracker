using BugTracker.Domain.Entities;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Data
{
    public interface IProjectRepository : IAsyncRepository<Project>
    {
        Task<bool> NameIsUnique(string name);
    }
}
