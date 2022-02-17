using BugTracker.Application.Features.Tickets.Commands.Update;
using BugTracker.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace BugTracker.Application.Dto.Tickets
{
    public class UpdateTicketDto
    {
        public UpdateTicketDto(Guid ticketId)
        {
            Command = new UpdateTicketCommand(ticketId);
        }


        public Guid ProjectId { get; set; }
        public UpdateTicketCommand Command { get; set; }
        public List<UserViewModel> Team { get; set; }
        public TicketConfigurationEntitiesViewModel TicketConfigurations { get; set; }
    }
}
