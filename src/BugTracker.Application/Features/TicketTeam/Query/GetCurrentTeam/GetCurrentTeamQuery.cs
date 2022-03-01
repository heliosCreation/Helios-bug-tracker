using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;

namespace BugTracker.Application.Features.TicketTeam.Query.GetCurrentTeam
{
    public class GetCurrentTeamQuery : IRequest<ApiResponse<UserViewModel>>
    {
        public GetCurrentTeamQuery(Guid ticketId)
        {
            TicketId = ticketId;
        }
        public Guid TicketId { get; set; }
    }
}
