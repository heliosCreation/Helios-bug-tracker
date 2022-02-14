using BugTracker.Application.Responses;
using MediatR;
using System;

namespace BugTracker.Application.Features.Tickets.Queries.GetProjectTickets
{
    public class GetProjectTicketsQuery : IRequest<ApiResponse<TicketVm>>
    {
        public GetProjectTicketsQuery(Guid projectId)
        {
            ProjectId = projectId;
        }

        public Guid ProjectId { get; set; }
    }
}
