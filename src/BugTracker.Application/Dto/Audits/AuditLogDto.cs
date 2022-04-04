using System;
using System.Collections.Generic;

namespace BugTracker.Application.Dto.Audits
{
    public class AuditLogDto
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public string TableName { get; set; }
        public Dictionary<string, string> OldValues { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> NewValues { get; set; } = new Dictionary<string, string>();
        public string Type { get; set; }
        public List<string> AffectedColumns { get; } = new List<string>();
        public DateTime DateTime { get; set; }
        public Dictionary<string, string> PrimaryKey { get; set; } = new Dictionary<string, string>();

    }
}
