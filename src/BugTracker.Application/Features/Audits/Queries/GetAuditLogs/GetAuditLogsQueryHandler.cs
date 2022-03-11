using AutoMapper;
using BugTracker.Application.Contracts.Audits;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Dto.Audits;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Audits.Queries
{
    public class GetAuditLogsQueryHandler : IRequestHandler<GetAuditLogsQuery, ApiResponse<AuditLogDto>>
    {
        private readonly IMapper _mapper;
        private readonly IAuditRepository _auditRepository;
        private readonly IIdentityService _identityService;
        private readonly ITicketConfigurationRepository _ticketConfigurationRepository;

        public GetAuditLogsQueryHandler(IMapper mapper,
            IAuditRepository auditRepository,
            IIdentityService identityService,
            ITicketConfigurationRepository ticketConfigurationRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _auditRepository = auditRepository ?? throw new ArgumentNullException(nameof(auditRepository));
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _ticketConfigurationRepository = ticketConfigurationRepository ?? throw new ArgumentNullException(nameof(ticketConfigurationRepository));
        }

        public async Task<ApiResponse<AuditLogDto>> Handle(GetAuditLogsQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<AuditLogDto>();
            var logToViewHelper = new LogToViewHelper(_identityService, _ticketConfigurationRepository);
            var audits = await _auditRepository.GetAudits(request.Id, request.Type);

            var mapped = _mapper.Map<List<AuditLogDto>>(audits);
            response.DataList = await logToViewHelper.AssignAuditLogtIdToTextAsync(mapped);
            return response;
        }

    }
}
