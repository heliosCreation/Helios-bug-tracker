using BugTracker.Application.Dto.Audits;
using System.Collections.Generic;

namespace BugTracker.Application.Dto.Tickets
{
    public class TicketDetailsDto
    {
        public List<AuditLogDto> History { get; set; }
    }
}
