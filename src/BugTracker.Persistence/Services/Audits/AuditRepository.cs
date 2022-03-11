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
                if (DateTime.TryParse(searchstring, out DateTime dateTime))
                {
                    if (dateTime.TimeOfDay == TimeSpan.Zero)
                    {
                        return await _context.AuditLogs
                            .Where(al => al.DateTime.Date == dateTime.Date)
                            .Skip(toSkip)
                            .Take(itemPerPage)
                            .ToListAsync();
                    }
                    else
                    {
                        return await _context.AuditLogs
                            .Where(al => al.DateTime.Date == dateTime.Date && al.DateTime.Hour == dateTime.Hour)
                            .Skip(toSkip)
                            .Take(itemPerPage)
                            .ToListAsync();
                    }
                }

                return await _context.AuditLogs
                            .Where(
                                    al => al.TableName.Contains(searchstring)
                                    || al.UserId == _context.Users
                                                           .Where(u => u.UserName.Contains(searchstring))
                                                           .Select(u => u.Id)
                                                           .FirstOrDefault()
                                    || al.OldValues.Contains(searchstring)
                                    || al.NewValues.Contains(searchstring)
                                    || al.Type.Contains(searchstring))
                            .Skip(toSkip)
                            .Take(itemPerPage)
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

        public async Task<int> CountAll(string searchString)
        {
            int count = 0;
            if (string.IsNullOrWhiteSpace(searchString))
            {
                return (await _context.AuditLogs.ToListAsync()).Count;
            }
            else
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    if (DateTime.TryParse(searchString, out DateTime dateTime))
                    {
                        if (dateTime.TimeOfDay == TimeSpan.Zero)
                        {
                            return (await _context.AuditLogs
                                .Where(al => al.DateTime.Date == dateTime.Date)
                                .ToListAsync())
                                .Count;
                        }
                        else
                        {
                            return (await _context.AuditLogs
                                .Where(al => al.DateTime.Date == dateTime.Date && al.DateTime.Hour == dateTime.Hour)
                                .ToListAsync())
                                .Count;
                        }
                    }

                    return (await _context.AuditLogs
                                .Where(
                                        al => al.TableName.Contains(searchString)
                                        || al.UserId == _context.Users
                                                               .Where(u => u.UserName.Contains(searchString))
                                                               .Select(u => u.Id)
                                                               .FirstOrDefault()
                                        || al.OldValues.Contains(searchString)
                                        || al.NewValues.Contains(searchString)
                                        || al.Type.Contains(searchString))
                                .ToListAsync())
                                .Count;
                }
                return count;
            }
        }
    }
}
