using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;

namespace BugTracker.Application.Features.UserManagement.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<ApiResponse<UserManagementViewModel>>
    {
        public GetAllUsersQuery(int page, string searchString, bool showLocked, bool showNoRole)
        {
            Page = page;
            SearchString = searchString;
            ShowLocked = showLocked;
            ShowNoRole = showNoRole;
            ShowNoRole = showNoRole;
        }

        public int Page { get; }
        public string SearchString { get; }
        public bool ShowLocked { get; }
        public bool ShowNoRole { get; }
    }
}
