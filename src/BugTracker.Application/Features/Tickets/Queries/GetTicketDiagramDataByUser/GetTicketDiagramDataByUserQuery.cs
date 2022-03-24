using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;

namespace BugTracker.Application.Features.Tickets.Queries.GetTicketDiagramDataByUser
{
    public class GetTicketDiagramDataByUserQuery : IRequest<ApiResponse<TicketDiagramDataModel>>
    {
    }
}
