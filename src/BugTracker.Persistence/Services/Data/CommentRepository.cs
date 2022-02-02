using BugTracker.Application.Contracts.Data;
using BugTracker.Domain.Entities;

namespace BugTracker.Persistence.Services.Data
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
