using BugTracker.Application.Responses;
using MediatR;

namespace BugTracker.Application.Features.UserManagement.Commands.LockUser
{
    public class LockUserCommand : IRequest<ApiResponse<object>>
    {
        public LockUserCommand(string uid)
        {
            Uid = uid;
        }
        public string Uid { get; }
    }
}
