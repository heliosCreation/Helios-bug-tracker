using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;

namespace BugTracker.Application.Features.Tickets.Queries.GetProjectTickets
{
    public class GetProjectTicketsQuery : IRequest<ApiResponse<ProjectWithTicketVm>>
    {
        public GetProjectTicketsQuery(Guid projectId, int page, int itemPerPage)
        {
            ProjectId = projectId;
            Page = page;
            ItemPerPage = itemPerPage;
        }

        public Guid ProjectId { get; set; }
        public int Page { get; set; }
        public int ItemPerPage { get; set; }
    }
}
