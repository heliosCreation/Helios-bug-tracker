using BugTracker.Application.Responses;
using MediatR;

namespace BugTracker.Application.Features.Projects.Queries.GetAll
{
    public class GetAllProjectQuery : IRequest<ApiResponse<ProjectVm>>
    {
    }
}
