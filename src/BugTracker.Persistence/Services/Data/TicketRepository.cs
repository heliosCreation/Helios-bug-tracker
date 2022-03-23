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
                    .Where(t => t.Id == id)
                    .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByUser(string uid, int page, string searchString, bool showOnlyCreated)
        {
            var itemPerPage = 7;
            var tickets = new List<Ticket>();
            var toSkip = (page - 1) * itemPerPage;

            if (showOnlyCreated)
            {
                return await _dbContext.Tickets
                    .Where(t => t.CreatedBy == Guid.Parse(uid))
                    .OrderByDescending(t => t.CreatedDate)
                    .Skip(toSkip)
                    .Take(itemPerPage)
                    .Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                    .ToListAsync();
            }
            var userTicketsId = await _dbContext.TicketsTeamMembers.Where(ttm => ttm.UserId == uid).Select(ttm => ttm.TicketId).ToListAsync();
            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                var userId = _dbContext.Users
                .Where(u => !u.UserName.ToLower().Contains("demo admin"))
                .Where(u => u.UserName.ToLower().Contains(searchString))
                .Select(u => u.Id)
                .FirstOrDefault();

                tickets = await _dbContext.Tickets
                        .Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                        .Where(t => userTicketsId.Contains(t.Id))
                        .Where(t => t.Name.ToLower().Contains(searchString)
                       || t.Priority.Name.ToLower().Contains(searchString)
                       || t.Status.Name.ToLower().Contains(searchString)
                       || t.Type.Name.ToLower().Contains(searchString)
                       || t.CreatedBy.ToString() == userId)
                        .ToListAsync();
            }
            else
            {
                tickets = await _dbContext.Tickets
                        .Where(t => userTicketsId.Contains(t.Id))
                        .OrderByDescending(t => t.CreatedDate)
                        .Skip(toSkip)
                        .Take(itemPerPage)

                        .Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                        .ToListAsync();
            }


            return tickets;
        }

        public async Task<IEnumerable<Ticket>> GetProjectManagerTickets(string uid, int page, string searchString)
        {
            var skip = (page - 1) * 7;
            var itemPerPage = 7;

            var projectIds = await _dbContext.ProjectTeamMembers.Where(ptm => ptm.UserId == uid).Select(ptm => ptm.ProjectId).ToListAsync();
            if (string.IsNullOrEmpty(searchString))
            {
                return await GetTicketPaginatedList(skip, itemPerPage, Guid.Empty, projectIds);
            }
            return await LookoutTicketBySearchString(searchString, Guid.Empty, projectIds, skip, itemPerPage);
        }

        public async Task<int> CountUserAssignedTickets(string uid)
        {
            return (await _dbContext.TicketsTeamMembers.Where(ttm => ttm.UserId == uid).ToListAsync()).Count();
        }

        public async Task<int> CountProjectTicket(string searchString, Guid projectId)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                var searchUserId = _dbContext.Users
                    .Where(u => !u.UserName.ToLower().Contains("demo admin"))
                    .Where(u => u.UserName.ToLower().Contains(searchString))
                    .Select(u => u.Id)
                    .FirstOrDefault();

                return (await _dbContext.Tickets
                .Where(t => t.ProjectId == projectId)
                .Where(t => t.Name.ToLower().Contains(searchString)
               || t.Priority.Name.ToLower().Contains(searchString)
               || t.Status.Name.ToLower().Contains(searchString)
               || t.Type.Name.ToLower().Contains(searchString)
               || t.CreatedBy.ToString() == searchUserId)
                .ToListAsync()).Count;
            }

            return (await _dbContext.Tickets
                    .Where(t => t.ProjectId == projectId)
                    .ToListAsync()).Count;
        }
        public async Task<int> GetDevTicketAmountByProject(string uid, Guid projectId, string searchString)
        {
            var projectTicketsId = await _dbContext.Tickets.Where(t => t.ProjectId == projectId).Select(t => t.Id).ToListAsync();
            var userTicketsId = await _dbContext.TicketsTeamMembers.Where(ttm => ttm.UserId == uid).Select(ttm => ttm.TicketId).ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                var searchUserId = _dbContext.Users
                    .Where(u => !u.UserName.ToLower().Contains("demo admin"))
                    .Where(u => u.UserName.ToLower().Contains(searchString))
                    .Select(u => u.Id)
                    .FirstOrDefault();

                return (await _dbContext.Tickets
                .Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                .Where(t => userTicketsId.Intersect(projectTicketsId).Contains(t.Id))
                .Where(t => t.Name.ToLower().Contains(searchString)
               || t.Priority.Name.ToLower().Contains(searchString)
               || t.Status.Name.ToLower().Contains(searchString)
               || t.Type.Name.ToLower().Contains(searchString)
               || t.CreatedBy.ToString() == searchUserId)
                .ToListAsync()).Count;
            }
            return (await _dbContext.Tickets
                .Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                .Where(t => userTicketsId.Intersect(projectTicketsId).Contains(t.Id))
                .ToListAsync()).Count;
        }

        public async Task<int> GetProjectManagerTicketCount(string uid)
        {
            var projectIds = await _dbContext.ProjectTeamMembers.Where(ptm => ptm.UserId == uid).Select(ptm => ptm.ProjectId).ToListAsync();
            var tickets = await _dbContext.Tickets.Where(t => projectIds.Contains(t.ProjectId)).ToListAsync();

            return tickets.Count();

        }
        public async Task<int> GetUserCreatedTicketAmount(string uid)
        {
            return (await _dbContext.Tickets.Where(t => t.CreatedBy == Guid.Parse(uid)).ToListAsync()).Count;
        }

        public override async Task<IEnumerable<Ticket>> ListAllAsync(int page, string searchString)
        {
            var itemPerPage = 6;
            var toSkip = (page - 1) * itemPerPage;
            var result = new List<Ticket>();

            if (!string.IsNullOrEmpty(searchString))
            {
                result = await LookoutTicketBySearchString(searchString, Guid.Empty, new List<Guid>(), toSkip, itemPerPage);
            }
            else
            {
                result = await GetTicketPaginatedList(toSkip, itemPerPage, Guid.Empty, new List<Guid>());
            }
            return result;
        }

        public async Task<IEnumerable<Ticket>> GetDevTicketByProject(string uid, Guid projectId, int page, string searchString)
        {
            var itemPerPage = 6;
            var tickets = new List<Ticket>();
            var toSkip = (page - 1) * itemPerPage;



            var projectTicketsId = await _dbContext.Tickets.Where(t => t.ProjectId == projectId).Select(t => t.Id).ToListAsync();
            var userTicketsId = await _dbContext.TicketsTeamMembers.Where(ttm => ttm.UserId == uid).Select(ttm=>ttm.TicketId).ToListAsync();


            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                var searchUserId = _dbContext.Users
                    .Where(u => !u.UserName.ToLower().Contains("demo admin"))
                    .Where(u => u.UserName.ToLower().Contains(searchString))
                    .Select(u => u.Id)
                    .FirstOrDefault();

                return await _dbContext.Tickets
                .Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                .Where(t => userTicketsId.Intersect(projectTicketsId).Contains(t.Id))
                .Where(t => t.Name.ToLower().Contains(searchString)
               || t.Priority.Name.ToLower().Contains(searchString)
               || t.Status.Name.ToLower().Contains(searchString)
               || t.Type.Name.ToLower().Contains(searchString)
               || t.CreatedBy.ToString() == searchUserId)
                .OrderByDescending(t => t.CreatedDate)
                .Skip(toSkip)
                .Take(itemPerPage)
                .ToListAsync();
            }
            else
            {
                return await _dbContext.Tickets
                        .Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                        .Where(t => userTicketsId.Intersect(projectTicketsId).Contains(t.Id))
                        .OrderByDescending(t => t.CreatedDate)
                        .Skip(toSkip)
                        .Take(itemPerPage)
                        .ToListAsync();
            }

        }

        public async Task<IEnumerable<Ticket>> GetTicketsByProject(Guid id, int page, string searchString)
        {
            var itemPerPage = 6;
            var tickets = new List<Ticket>();
            var toSkip = (page - 1) * itemPerPage;

            if (!string.IsNullOrEmpty(searchString))
            {
                tickets = await LookoutTicketBySearchString(searchString, id, new List<Guid>(), toSkip, itemPerPage);
            }
            else
            {
                tickets = await GetTicketPaginatedList(toSkip, itemPerPage, id, new List<Guid>());
            }


            return tickets;
        }
        public async Task<bool> NameIsUnique(string name)
        {
            return await _dbContext.Tickets.AsNoTracking().AnyAsync(t => t.Name == name) == false;
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
            var oldEntity = await _dbContext.Tickets.FindAsync(entity.Id);
            _dbContext.Entry(oldEntity).CurrentValues.SetValues(entity);

            if (teamIds.Count > 0)
            {
                var dbTicketMemberIds = await GetTicketTeamIds(entity);
                RemoveFromTicketTeam(entity, dbTicketMemberIds, teamIds);
                await AddToTicketTeam(entity, dbTicketMemberIds, teamIds);
            }


            var result =  await _dbContext.SaveChangesAsync();

            return result > 0;
        }
        public async Task<bool> NameIsUnique(string name, bool isAnUpdate, Guid id)
        {
            if (isAnUpdate)
            {
                return await _dbContext.Tickets.SingleOrDefaultAsync(p => p.Name == name && p.Id != id) == null;
            }
            return await _dbContext.Tickets.SingleOrDefaultAsync(p => p.Name == name) == null;
        }
        public async Task<bool> UserBelongsToTicketTeam(string uid, Guid ticketId)
        {
            var x =  await _dbContext.TicketsTeamMembers.AnyAsync(ttm => ttm.TicketId == ticketId && ttm.UserId == uid);
            return x;
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
        private async Task<List<Ticket>> LookoutTicketBySearchString(string searchString, Guid id, List<Guid> projectIds, int skip, int itemPerPage)
        {
            searchString = searchString.ToLower();
            var searchUserId = _dbContext.Users
                .Where(u => !u.UserName.ToLower().Contains("demo admin"))
                .Where(u => u.UserName.ToLower().Contains(searchString))
                .Select(u => u.Id)
                .FirstOrDefault();

            if (id != Guid.Empty)
            {
                return  await _dbContext.Tickets
                                .Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                                .Where(t => t.ProjectId == id)
                                .Where(t => t.Name.ToLower().Contains(searchString)
                               || t.Priority.Name.ToLower().Contains(searchString)
                               || t.Status.Name.ToLower().Contains(searchString)
                               || t.Type.Name.ToLower().Contains(searchString)
                               || t.CreatedBy.ToString() == searchUserId)
                                .Skip(skip)
                                .Take(itemPerPage)
                                .ToListAsync();
            }
            if (projectIds.Count > 0)
            {
                return await _dbContext.Tickets
                .Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                .Where(t => projectIds.Contains(t.ProjectId))
                .Where(t => t.Name.ToLower().Contains(searchString)
               || t.Priority.Name.ToLower().Contains(searchString)
               || t.Status.Name.ToLower().Contains(searchString)
               || t.Type.Name.ToLower().Contains(searchString)
               || t.CreatedBy.ToString() == searchUserId)
                .Skip(skip)
                .Take(itemPerPage)
                .ToListAsync();
            }
            else
            {
                return  await _dbContext.Tickets
                                .Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                                .Where(t => t.Name.ToLower().Contains(searchString)
                               || t.Priority.Name.ToLower().Contains(searchString)
                               || t.Status.Name.ToLower().Contains(searchString)
                               || t.Type.Name.ToLower().Contains(searchString)
                               || t.CreatedBy.ToString() == searchUserId)
                                .Skip(skip)
                                .Take(itemPerPage)
                                .ToListAsync();

            }

        }
        
        private async Task<List<Ticket>> GetTicketPaginatedList(int skip, int itemPerPage, Guid projectId, List<Guid> projectIds)
        {
            if (projectId != Guid.Empty)
            {
                return await _dbContext.Tickets
                                .Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                                .Where(t => t.ProjectId == projectId)
                                .OrderByDescending(t => t.CreatedDate)
                                .Skip(skip)
                                .Take(itemPerPage)
                                .ToListAsync();
            }
            if (projectIds.Count > 0)
            {
                return await _dbContext.Tickets.
                        Where(t => projectIds.Contains(t.ProjectId))
                        .OrderByDescending(t => t.CreatedDate)
                        .Skip(skip)
                        .Take(itemPerPage)
                        .Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                        .ToListAsync();
            }
            else
            {
                return await _dbContext.Tickets
                                .OrderByDescending(t => t.CreatedDate)
                                .Skip(skip)
                                .Take(itemPerPage)
                                .Include(t => t.Priority).Include(t => t.Status).Include(t => t.Type)
                                .ToListAsync();
            }

        }
    }
}
