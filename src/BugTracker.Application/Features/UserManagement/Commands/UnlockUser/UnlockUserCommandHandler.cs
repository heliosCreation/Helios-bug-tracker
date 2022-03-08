using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.UserManagement.Commands.UnlockUser
{
    public class UnlockUserCommandHandler : IRequestHandler<UnlockUserCommand, ApiResponse<object>>
    {
        private readonly IIdentityService _identityService;

        public UnlockUserCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
        }
        public async Task<ApiResponse<object>> Handle(UnlockUserCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<object>();

            var unlocked = await _identityService.UnlockUser(request.Uid);
            if (!unlocked)
            {
                response.SetBadRequestResponse($"The user with Id:{request.Uid} could not be unlocked. Contact your administator if the problem persists");
            }

            return response;
        }
    }
}
