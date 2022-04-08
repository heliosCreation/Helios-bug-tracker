using BugTracker.Application.Dto.UserManagement;
using System.Collections.Generic;

namespace BugTracker.Application.ViewModel
{
    public class ManageUserRoleViewModel
    {
        public UserWithRoleDto UserWithRoles { get; set; }
        public List<RoleDto> AvailableRoles { get; set; }
        public int Page { get; set; }
    }
}
