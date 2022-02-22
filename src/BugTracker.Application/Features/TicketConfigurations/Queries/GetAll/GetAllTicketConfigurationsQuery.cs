using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;

namespace BugTracker.Application.Features.TicketConfigurations.Queries.GetAll
{
    public class GetAllTicketConfigurationsQuery : IRequest<ApiResponse<TicketConfigurationEntitiesViewModel>>
    {
    }
}
