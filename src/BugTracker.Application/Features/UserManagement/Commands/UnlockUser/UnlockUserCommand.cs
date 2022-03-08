using BugTracker.Application.Responses;
using MediatR;

namespace BugTracker.Application.Features.UserManagement.Commands.UnlockUser
{
    public class UnlockUserCommand : IRequest<ApiResponse<object>>
    {
        public UnlockUserCommand(string uid)
        {
            Uid = uid;
        }

        public string Uid { get; }
    }
}
