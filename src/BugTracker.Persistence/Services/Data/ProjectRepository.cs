using BugTracker.Application.Contracts.Data;
using BugTracker.Domain.Entities;

namespace BugTracker.Persistence.Services.Data
{
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
