using AutoMapper;
using BugTracker.Application.Contracts.Audits;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Dto.Audits;
using BugTracker.Application.Enums;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var audits = await _auditRepository.GetAudits(request.Id, request.Type);

            var mapped = _mapper.Map<List<AuditLogDto>>(audits);
            response.DataList = await AssignAudiLogtIdToTextAsync(mapped);
            return response;
        }

        private async Task<List<AuditLogDto>> AssignAudiLogtIdToTextAsync(List<AuditLogDto> auditLogs)
        {
            foreach (var item in auditLogs)
            {
                item.User = await _identityService.GetUserNameById(item.User);
                if (item.Type == AuditType.Update.ToString())
                {
                    if (item.AffectedColumns.Contains("PriorityId"))
                    {

                        var newVal = item.NewValues.Where(nv => nv.Key == "PriorityId").First().Value;
                        var oldVal = item.OldValues.Where(nv => nv.Key == "PriorityId").First().Value;
                        var newPriorityName = await _ticketConfigurationRepository.GetPriorityName(Guid.Parse(newVal));
                        var oldPriorityName = await _ticketConfigurationRepository.GetPriorityName(Guid.Parse(oldVal));
                        item.NewValues.Remove("PriorityId");
                        item.OldValues.Remove("PriorityId");
                        item.NewValues.Add("Priority", newPriorityName);
                        item.OldValues.Add("Priority", oldPriorityName);
                    }
                }
            }

            return auditLogs;
        }
    }
}
