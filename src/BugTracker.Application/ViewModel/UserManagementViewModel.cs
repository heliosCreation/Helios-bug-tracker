using BugTracker.Application.Model.Pagination;
using System.Collections.Generic;

namespace BugTracker.Application.ViewModel
{
    public class UserManagementViewModel
    {
        public List<UserViewModel> Users { get; set; } = new List<UserViewModel>();
        public Pager Pager { get; set; }
    }
}
