using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Application.Dto.Comments
{
    public class CreateCommentDto
    {
        public Guid TicketId { get; set; }
        public string Message { get; set; }
    }
}
