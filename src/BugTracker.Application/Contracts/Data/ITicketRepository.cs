using BugTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Data
{
    public interface ITicketRepository : IAsyncRepository<Ticket>
    {
        Task<Ticket> AddTicketAsync(Ticket entity, ICollection<string> teamIds);
        Task<int> CountUserAssignedTickets(string uid);
        Task<int> GetProjectManagerTicketCount(string uid);
        Task<IEnumerable<Ticket>> GetProjectManagerTickets(string uid, int page, string searchString);
        Task<IEnumerable<Ticket>> GetTicketsByProject(Guid id, int page, string searchString ="");
        Task<IEnumerable<Ticket>> GetTicketsByUser(string uid, int page, string searchString, bool showOnlyCreated);
        Task<Ticket> GetTicketWithTeamAndConfiguration(Guid id);
        Task<int> GetUserCreatedTicketAmount(string uid);
        Task<bool> NameIsUnique(string name, bool isAnUpdate, Guid id = new Guid());
        Task<bool> UpdateTicketAsync(Ticket entity, ICollection<string> teamIds);
        Task<bool> UserBelongsToTicketTeam(string uid, Guid ticketId);
    }
}
