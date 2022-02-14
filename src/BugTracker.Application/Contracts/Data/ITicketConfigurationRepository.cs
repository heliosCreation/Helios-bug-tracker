using BugTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Type = BugTracker.Domain.Entities.Type;
namespace BugTracker.Application.Contracts.Data
{
    public interface ITicketConfigurationRepository
    {
        Task<List<Type>> GetTypes();
        Task<string> GetTypeName(Guid id);
        Task<List<Priority>> GetPriorities();
        Task<string> GetPriorityName(Guid id);
        Task<List<Status>> GetStatuses();
        Task<string> GetStatusName(Guid id);

    }
}
