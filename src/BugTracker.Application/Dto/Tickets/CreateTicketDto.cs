using BugTracker.Application.Features.Tickets.Commands.Create;
using BugTracker.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace BugTracker.Application.Dto.Tickets
{
    public class CreateTicketDto
    {
        public CreateTicketDto(Guid projectId)
        {
            Command = new CreateTicketCommand(projectId);
        }

        public string ProjectName { get; set; }
        public CreateTicketCommand Command { get; set; }
        public List<UserViewModel> Team { get; set; }
        public  TicketConfigurationEntitiesViewModel TicketConfigurations { get; set; }

    }
}
