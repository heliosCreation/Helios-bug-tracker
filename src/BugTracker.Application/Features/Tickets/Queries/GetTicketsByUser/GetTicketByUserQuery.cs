using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;

namespace BugTracker.Application.Features.Tickets.Queries.GetTicketsByUser
{
    public class GetTicketByUserQuery : IRequest<ApiResponse<UserTicketsVm>>
    {
        public GetTicketByUserQuery(int page, string search)
        {
            Page = page;
            Search = search;
        }

        public int Page { get; }
        public string Search { get; }
    }
}
