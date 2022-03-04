using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Dto.UserManagement;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.UserManagement.GetUserWithRoles
{
    public class GetUserWithRoleQueryHandler : IRequestHandler<GetUserWithRoleQuery, ApiResponse<UserWithRoleDto>>
    {
        private readonly IIdentityService _identityService;

        public GetUserWithRoleQueryHandler(IIdentityService identityService)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
        }
        public async Task<ApiResponse<UserWithRoleDto>> Handle(GetUserWithRoleQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<UserWithRoleDto>();
            response.Data = new UserWithRoleDto(request.UserId);

            response.Data.UserName = await _identityService.GetUserNameById(request.UserId);
            var roles = await _identityService.GetUserRolesById(request.UserId);
            foreach (var role in roles)
            {
                response.Data.RolesDto.Add(new RoleDto
                {
                    Name = role.Name,
                    Id = role.Id
                });
            }

            return response; 
        }
    }
}
