using BugTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Data
{
    public interface ICommentRepository : IAsyncRepository<Comment>
    {
        Task<IEnumerable<Comment>> GetByTicket(Guid ticketId);
    }
}
