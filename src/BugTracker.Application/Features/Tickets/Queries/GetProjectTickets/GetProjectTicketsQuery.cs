using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;

namespace BugTracker.Application.Features.Tickets.Queries.GetProjectTickets
{
    public class GetProjectTicketsQuery : IRequest<ApiResponse<ProjectWithTicketVm>>
    {
        public GetProjectTicketsQuery(Guid projectId, int page, string searchString)
        {
            ProjectId = projectId;
            Page = page;
            SearchString = searchString;
        }

        public Guid ProjectId { get; set; }
        public int Page { get; set; }
        public string SearchString { get; set; }
    }
}
