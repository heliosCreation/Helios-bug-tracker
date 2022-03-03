using AutoMapper;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Model.Pagination;
using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.UserManagement.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, ApiResponse<UserManagementViewModel>>
    {
        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;

        public GetAllUsersQueryHandler(IIdentityService identityService, IMapper mapper)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ApiResponse<UserManagementViewModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<UserManagementViewModel>();
            response.Data = new UserManagementViewModel();

            var users = _mapper.Map<List<UserViewModel>>(await _identityService.GetAllManageableUsers(request.Page,request.SearchString));
            var userCount = await _identityService.CountManageableUsers();

            foreach (var user in users)
            {
                var roles = await _identityService.GetUserRolesById(user.Id.ToString());
                if (roles.Any())
                {
                    user.Role = roles.ToList()[0];
                    response.Data.Users.Add(user);
                }
            }
            response.Data.Users = response.Data.Users.OrderBy(tm => tm.Role).ToList();
            response.Data.Pager = new Pager(userCount, request.Page);


            return response;
        }
    }
}
