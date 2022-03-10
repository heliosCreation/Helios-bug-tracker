using BugTracker.Application.Dto.Audits;
using BugTracker.Application.Model.Pagination;
using System.Collections.Generic;

namespace BugTracker.Application.ViewModel
{
    public class LogViewModel
    {
        public List<AuditLogDto> Logs { get; set; } = new List<AuditLogDto>();
        public Pager Pager { get; set; }
    }
}
