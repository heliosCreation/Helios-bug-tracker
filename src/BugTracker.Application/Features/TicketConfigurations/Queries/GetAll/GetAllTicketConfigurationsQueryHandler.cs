using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Dto.TicketConfiguration;
using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketConfigurations.Queries.GetAll
{
    public class GetAllTicketConfigurationsQueryHandler : IRequestHandler<GetAllTicketConfigurationsQuery, ApiResponse<TicketConfigurationEntitiesViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly ITicketConfigurationRepository _ticketConfigurationRepository;

        public GetAllTicketConfigurationsQueryHandler(IMapper mapper, ITicketConfigurationRepository ticketConfigurationRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _ticketConfigurationRepository = ticketConfigurationRepository ?? throw new ArgumentNullException(nameof(ticketConfigurationRepository));
        }
        public async Task<ApiResponse<TicketConfigurationEntitiesViewModel>> Handle(GetAllTicketConfigurationsQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<TicketConfigurationEntitiesViewModel>();
            response.Data = new TicketConfigurationEntitiesViewModel();
            response.Data.Priorities = _mapper.Map<List<PriorityDto>>(await _ticketConfigurationRepository.GetPriorities());
            response.Data.Types = _mapper.Map<List<TypeDto>>(await _ticketConfigurationRepository.GetTypes());
            response.Data.Statuses = _mapper.Map<List<StatusDto>>(await _ticketConfigurationRepository.GetStatuses());

            return response;
        }
    }
}
