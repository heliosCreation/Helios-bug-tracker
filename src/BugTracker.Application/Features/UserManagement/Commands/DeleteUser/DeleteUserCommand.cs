using BugTracker.Application.Responses;
using MediatR;

namespace BugTracker.Application.Features.UserManagement.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest<ApiResponse<object>>
    {
        public DeleteUserCommand(string uid)
        {
            Uid = uid;
        }

        public string Uid { get; }
    }
}
