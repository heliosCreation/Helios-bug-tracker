using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;

namespace BugTracker.Application.Features.Audits.Queries.GetAllLogs
{
    public class GetAllLogsQuery : IRequest<ApiResponse<LogViewModel>>
    {
    }
}
