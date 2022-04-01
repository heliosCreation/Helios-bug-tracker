using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.UserManagement.Commands.UpdateUserRole
{
    public class UpdateUserRolesCommandHandler : IRequestHandler<UpdateUserRolesCommand, ApiResponse<object>>
    {
        private readonly IIdentityService _identityService;

        public UpdateUserRolesCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
        }
        public async Task<ApiResponse<object>> Handle(UpdateUserRolesCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<object>();

            var updated = await _identityService.UpdateUserRoles(request.UserId, request.RoleId);
            if (!updated)
            {
                return response.SetBadRequestResponse("There was one or more errors trying to update you user roles.");
            }

            return response;
        }
    }
}
