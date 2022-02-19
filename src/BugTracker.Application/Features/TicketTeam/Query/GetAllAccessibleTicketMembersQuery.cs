using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;

namespace BugTracker.Application.Features.TicketTeam.Query
{
    public class GetAllAccessibleTicketMembersQuery : IRequest<ApiResponse<UserViewModel>>
    {
        public GetAllAccessibleTicketMembersQuery(Guid projectId)
        {
            ProjectId = projectId;
        }

        public Guid ProjectId { get; }
    }
}
