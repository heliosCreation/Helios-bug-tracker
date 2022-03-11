using BugTracker.Application.Enums;
using BugTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Application.Contracts.Audits
{
    public interface IAuditRepository
    {
        Task<int> CountAll(string searchString);
        Task<IEnumerable<Audit>> GetAudits(Guid entityId, AuditableType type);
        Task<IEnumerable<Audit>> ListAll(int page, string searchstring);
    }
}
