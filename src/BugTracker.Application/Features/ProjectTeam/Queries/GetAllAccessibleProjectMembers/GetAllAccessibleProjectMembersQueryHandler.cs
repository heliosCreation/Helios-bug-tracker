using AutoMapper;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Features.ProjectTeam.Queries.GetAllAccessibleMembers;
using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Team.Queries.GetAllAccessibleMembers
{
    public class GetAllAccessibleMembersQueryHandler : IRequestHandler<GetAllAccessibleProjectMembersQuery, ApiResponse<UserViewModel>>
    {
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;

        public GetAllAccessibleMembersQueryHandler(ILoggedInUserService loggedInUserService, IIdentityService identityService, IMapper mapper)
        {
            _loggedInUserService = loggedInUserService ?? throw new ArgumentNullException(nameof(loggedInUserService));
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ApiResponse<UserViewModel>> Handle(GetAllAccessibleProjectMembersQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<UserViewModel>();
            var uid = _loggedInUserService.UserId;

            var accessibleUsers = _mapper.Map<List<UserViewModel>>(await _identityService.GetAllAccessibleUsersPerRole(uid));

            foreach (var user in accessibleUsers)
            {
                var roles = await _identityService.GetUserRolesById(user.Id.ToString());
                if (roles.Any())
                {
                    user.Role = roles.Select(r => r.Name).ToList()[0];
                    response.DataList.Add(user);
                }
            }
            response.DataList = response.DataList.OrderBy(tm => tm.Role).ToList();
            return response;

        }
    }
}
