using BugTracker.Domain.Entities;

namespace BugTracker.Application.Contracts.Data
{
    public interface IProjectRepository : IAsyncRepository<Project>
    {
    }
}
