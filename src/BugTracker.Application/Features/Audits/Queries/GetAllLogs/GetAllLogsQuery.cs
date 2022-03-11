using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;

namespace BugTracker.Application.Features.Audits.Queries.GetAllLogs
{
    public class GetAllLogsQuery : IRequest<ApiResponse<LogViewModel>>
    {
        public GetAllLogsQuery(int page, string searchstring)
        {
            Page = page;
            Searchstring = searchstring;
        }

        public int Page { get; }
        public string Searchstring { get; }
    }
}
