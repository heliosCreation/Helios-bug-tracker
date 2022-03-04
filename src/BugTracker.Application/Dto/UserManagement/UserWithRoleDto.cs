using System.Collections.Generic;

namespace BugTracker.Application.Dto.UserManagement
{
    public class UserWithRoleDto
    {
        public UserWithRoleDto()
        {
        }

        public UserWithRoleDto(string userId)
        {
            UserId = userId;
        }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<RoleDto> RolesDto { get; set; } = new List<RoleDto>();
        public List<string> SelectedRoles { get; set; }
    }
}
