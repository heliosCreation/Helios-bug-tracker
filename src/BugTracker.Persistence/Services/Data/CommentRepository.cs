using BugTracker.Application.Contracts.Data;
using BugTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Services.Data
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Comment>> GetByTicket(Guid ticketId)
        {
            return await _dbContext.Comments.
                         Where(c => c.TicketId == ticketId)
                         .OrderBy(c => c.CreatedDate)
                         .ToListAsync();
        }
    }
}
