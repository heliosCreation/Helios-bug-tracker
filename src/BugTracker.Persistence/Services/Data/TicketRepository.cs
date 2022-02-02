using BugTracker.Application.Contracts.Data;
using BugTracker.Domain.Entities;

namespace BugTracker.Persistence.Services.Data
{
    public class TicketRepository : BaseRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
