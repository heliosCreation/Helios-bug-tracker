using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.UserManagement.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, ApiResponse<object>>
    {
        private readonly IIdentityService _identityService;

        public DeleteUserCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
        }
        public async Task<ApiResponse<object>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<object>();

            var deleteResult = await _identityService.DeleteUserAsync(request.Uid);
            if (!deleteResult.Succeeded)
            {
                response.SetBadRequestResponse($"User with Id:{request.Uid} could not be deleted.If the problem persist, contact your administrator");
                return response;
            }

            return response;
        }
    }
}
