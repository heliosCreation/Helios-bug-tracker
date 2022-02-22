using BugTracker.Application.Responses;
using MediatR;
using System;

namespace BugTracker.Application.Features.Tickets.Queries.GetTicket
{
    public class GetTicketQuery : IRequest<ApiResponse<TicketWithTeamAndConfigurationVm>>
    {
        public GetTicketQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
