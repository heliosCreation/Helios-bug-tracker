using BugTracker.Application.Contracts.Audits;
using BugTracker.Application.Enums;
using BugTracker.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
                            .OrderBy(a => a.DateTime)
                            .ToListAsync();
            }


            return audits;
        }

        public async Task<IEnumerable<Audit>> ListAll(int page, string searchstring)
        {
            var itemPerPage = 6;
            var toSkip = (page - 1) * itemPerPage;
            var logs = new List<Audit>();

            if (!string.IsNullOrEmpty(searchstring))
            {
                return await _context.AuditLogs
                            .Where(al => al.DateTime.ToString().Contains(searchstring)
                            || al.TableName.Contains(searchstring)
                            || al.UserId == _context.Users
                                                   .Where(u => u.UserName.Contains(searchstring))
                                                   .Select(u => u.Id)
                                                   .FirstOrDefault()
                            || al.OldValues.Contains(searchstring)
                            || al.NewValues.Contains(searchstring)
                            || al.Type.Contains(searchstring))
                        .OrderByDescending(al => al.DateTime)
                            .ToListAsync();
            }

            return await _context.AuditLogs
                        .OrderByDescending(a => a.DateTime)
                        .ThenBy(a => a.DateTime.Hour)
                        .ThenBy(a => a.DateTime.Minute)
                        .Skip(toSkip)
                        .Take(itemPerPage)
                        .ToListAsync();
        }

        public async Task<int> CountAll()
        {
            return (await _context.AuditLogs.ToListAsync()).Count;
        }
    }
}
