using BugTracker.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Data
{
    public interface ITicketRepository : IAsyncRepository<Ticket>
    {
        Task<Ticket> AddTicketAsync(Ticket entity, ICollection<string> teamIds);
        Task<bool> NameIsUnique(string name);
    }
}
