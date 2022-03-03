using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;

namespace BugTracker.Application.Features.UserManagement.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<ApiResponse<UserViewModel>>
    {
        public GetAllUsersQuery(int page, string searchString)
        {
            Page = page;
            SearchString = searchString;
        }

        public int Page { get; }
        public string SearchString { get; }
    }
}
