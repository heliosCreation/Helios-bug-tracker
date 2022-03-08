using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;

namespace BugTracker.Application.Features.UserManagement.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<ApiResponse<UserManagementViewModel>>
    {
        public GetAllUsersQuery(int page, string searchString, bool showLocked)
        {
            Page = page;
            SearchString = searchString;
            ShowLocked = showLocked;
        }

        public int Page { get; }
        public string SearchString { get; }
        public bool ShowLocked { get; }
    }
}
