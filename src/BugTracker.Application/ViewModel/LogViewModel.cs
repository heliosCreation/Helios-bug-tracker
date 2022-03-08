using BugTracker.Application.Dto.Logs;
using System.Collections.Generic;

namespace BugTracker.Application.ViewModel
{
    public class LogViewModel
    {
        public List<LogDto> Logs { get; set; } = new List<LogDto>();
    }
}
