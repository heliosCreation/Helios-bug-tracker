using BugTracker.Application.Dto.Audits;
using System.Collections.Generic;

namespace BugTracker.Application.ViewModel
{
    public class LogViewModel
    {
        public List<AuditLogDto> Logs { get; set; } = new List<AuditLogDto>();
    }
}
