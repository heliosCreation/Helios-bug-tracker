using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.UserManagement.Commands.LockUser
{
    public class LockUserCommandHandler : IRequestHandler<LockUserCommand, ApiResponse<object>>
    {
        private readonly IIdentityService _identityService;

        public LockUserCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public async Task<ApiResponse<object>> Handle(LockUserCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<object>();

            var locked = await _identityService.LockOutUser(request.Uid);
            if (!locked)
            {
                response.SetBadRequestResponse($"The user with Id:{request.Uid} could not be locked. Contact your administator if the problem persists");
            }

            return response;
        }
    }
}
