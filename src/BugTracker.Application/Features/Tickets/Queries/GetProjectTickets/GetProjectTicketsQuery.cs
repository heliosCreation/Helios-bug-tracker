using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;

namespace BugTracker.Application.Features.Tickets.Queries.GetProjectTickets
{
    public class GetProjectTicketsQuery : IRequest<ApiResponse<ProjectWithTicketVm>>
    {
        public GetProjectTicketsQuery(Guid projectId)
        {
            ProjectId = projectId;
        }

        public Guid ProjectId { get; set; }
    }
}
