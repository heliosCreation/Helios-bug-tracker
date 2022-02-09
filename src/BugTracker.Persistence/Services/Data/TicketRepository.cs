using BugTracker.Application.Contracts.Data;
using BugTracker.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Services.Data
{
    public class TicketRepository : BaseRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }


        //public async Task<Ticket> AddTicketAsync(Project entity, ICollection<string> teamIds)
        //{

        //    await _dbContext.Projects.AddAsync(entity);
        //    foreach (var id in teamIds)
        //    {
        //        await _dbContext.ProjectTeamMembers.AddAsync(new ProjectTeamMember { ProjectId = entity.Id, UserId = id });
        //    }

        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}
    }
}
