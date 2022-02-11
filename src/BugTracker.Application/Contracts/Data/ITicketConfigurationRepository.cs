using BugTracker.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BugTracker.Application.Contracts.Data
{
    public interface ITicketConfigurationRepository
    {
        Task<List<Type>> GetTypes();
        Task<List<Priority>> GetPriorities();
        Task<List<Status>> GetStatuses();
    }
}
