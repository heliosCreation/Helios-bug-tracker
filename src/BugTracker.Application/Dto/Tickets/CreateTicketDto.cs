using BugTracker.Application.Features.Tickets.Commands.Create;
using BugTracker.Application.ViewModel;
using System.Collections.Generic;

namespace BugTracker.Application.Dto.Tickets
{
    public class CreateTicketDto
    {
        public CreateTicketCommand Command { get; set; }
        public List<UserViewModel> Team { get; set; }

    }
}
