using BugTracker.Application.Contracts.Data;
using BugTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Services.Data
{
    public class TicketRepository : BaseRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Ticket> GetTicketWithTeamAndConfiguration(Guid id)
        {
            return await _dbContext.Tickets
                    .Include(t => t.TicketsTeamMembers)
                    .Include(t => t.Status)
                    .Include(t => t.Priority)
                    .Include(t => t.Type)
                    .FirstOrDefaultAsync();
        }
        public async Task<Ticket> AddTicketAsync(Ticket entity, ICollection<string> teamIds)
        {

            await _dbContext.Tickets.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            foreach (var id in teamIds)
            {
                await _dbContext.TicketsTeamMembers.AddAsync(new TicketsTeamMembers { TicketId = entity.Id, UserId = id });
            }

            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> UpdateTicketAsync(Ticket entity, ICollection<string> teamIds)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;

            var dbTicketMemberIds = await GetTicketTeamIds(entity);
            RemoveFromTicketTeam(entity, dbTicketMemberIds, teamIds);
            await AddToTicketTeam(entity, dbTicketMemberIds, teamIds);

            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByProject(Guid id)
        {
            return await _dbContext.Tickets.Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                        .Where(t => t.ProjectId == id)
                        .OrderBy(t => t.CreatedDate)
                        .ToListAsync();
        }
        public async Task<bool> NameIsUnique(string name)
        {
            return await _dbContext.Tickets.AsNoTracking().AnyAsync(t => t.Name == name) == false;
        }

        public async Task<bool> NameIsUnique(string name, bool isAnUpdate, Guid id)
        {
            if (isAnUpdate)
            {
                return await _dbContext.Tickets.SingleOrDefaultAsync(p => p.Name == name && p.Id != id) == null;
            }
            return await _dbContext.Tickets.SingleOrDefaultAsync(p => p.Name == name) == null;
        }

        private async Task<List<string>> GetTicketTeamIds(Ticket entity)
        {
            return await _dbContext.
                        TicketsTeamMembers.
                        Where(ttm => ttm.TicketId == entity.Id).
                        Select(ttm => ttm.UserId).ToListAsync();
        }
        private void RemoveFromTicketTeam(Ticket entity, List<string> dbTicketTeamMembers, ICollection<string> requestTeamMembers)
        {
            foreach (var id in dbTicketTeamMembers)
            {
                if (!requestTeamMembers.Contains(id))
                {
                    _dbContext.TicketsTeamMembers.Remove(new TicketsTeamMembers { TicketId = entity.Id, UserId = id });
                }
            }
        }

        private async Task AddToTicketTeam(Ticket entity, List<string> dbTicketTeamMembers, ICollection<string> requestTeamMembers)
        {
            foreach (var id in requestTeamMembers)
            {
                if (!dbTicketTeamMembers.Contains(id))
                {
                    await _dbContext.TicketsTeamMembers.AddAsync(new TicketsTeamMembers { TicketId = entity.Id, UserId = id });
                }
            }
        }
    }
}
