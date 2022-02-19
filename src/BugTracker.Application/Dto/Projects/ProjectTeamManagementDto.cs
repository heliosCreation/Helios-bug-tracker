using BugTracker.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace BugTracker.Application.Dto.Projects
{
    public class ProjectTeamManagementDto
    {
        public Guid ProjectId { get; set; }
        public List<UserViewModel> Team { get; set; }
    }
}
