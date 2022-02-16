using BugTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Data
{
    public interface ITicketRepository : IAsyncRepository<Ticket>
    {
        Task<Ticket> AddTicketAsync(Ticket entity, ICollection<string> teamIds);
        Task<IEnumerable<Ticket>> GetTicketsByProject(Guid id);
        Task<Ticket> GetTicketWithTeamAndConfiguration(Guid id);
        Task<bool> NameIsUnique(string name, bool isAnUpdate, Guid id = new Guid());
        Task<bool> UpdateTicketAsync(Ticket entity, ICollection<string> teamIds);
    }
}
