using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;

namespace BugTracker.Application.Features.Projects.Queries.GetAll
{
    public class GetAllProjectQuery : IRequest<ApiResponse<DashboardViewModel>>
    {
        public GetAllProjectQuery(int page)
        {
            Page = page;
        }
        public int Page { get; }

    }
}
