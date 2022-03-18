using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;

namespace BugTracker.Application.Features.Tickets.Queries.GetTicketsByUser
{
    public class GetTicketByUserQuery : IRequest<ApiResponse<UserTicketsVm>>
    {
        public GetTicketByUserQuery(int page, string search, bool showOnlyCreated, bool showAll)
        {
            Page = page;
            Search = search;
            ShowOnlyCreated = showOnlyCreated;
            ShowAll = showAll;
        }

        public int Page { get; }
        public string Search { get; }
        public bool ShowOnlyCreated { get; }
        public bool ShowAll { get; }
    }
}
