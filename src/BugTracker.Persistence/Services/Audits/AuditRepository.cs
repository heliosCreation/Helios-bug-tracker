using BugTracker.Application.Contracts.Audits;
using BugTracker.Application.Enums;
using BugTracker.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Services.Audits
{
    public class AuditRepository : IAuditRepository
    {
        private readonly ApplicationDbContext _context;

        public AuditRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Audit>> GetAudits(Guid entityId, AuditableType type)
        {
            List<Audit> audits = new List<Audit>();
            if (type == AuditableType.Ticket)
            {
                var query = @"SELECT * FROM AuditLogs
                            WHERE JSON_VALUE(PrimaryKey, '$.Id') = {0}
                            AND TableName = {1}
                            Or JSON_VALUE(PrimaryKey, '$.TicketId') = {0}";
                                
                audits = await _context.AuditLogs
                            .FromSqlRaw(query, entityId, type.ToString())
                            .OrderByDescending(a => a.DateTime)
                            .ToListAsync();
            }


            return audits;
        }
    }
}
