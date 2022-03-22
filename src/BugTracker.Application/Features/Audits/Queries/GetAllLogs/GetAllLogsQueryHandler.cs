using AutoMapper;
using BugTracker.Application.Contracts.Audits;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Dto.Audits;
using BugTracker.Application.Model.Pagination;
using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Audits.Queries.GetAllLogs
{
    public class GetAllLogsQueryHandler : IRequestHandler<GetAllLogsQuery, ApiResponse<LogViewModel>>
    {
        private readonly IIdentityService _identityService;
        private readonly IAuditRepository _auditRepository;
        private readonly ITicketConfigurationRepository _ticketConfigurationRepository;
        private readonly IMapper _mapper;

        public GetAllLogsQueryHandler(
            IIdentityService identityService,
            IAuditRepository auditRepository,
            ITicketConfigurationRepository ticketConfigurationRepository,
            IMapper mapper)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _auditRepository = auditRepository ?? throw new ArgumentNullException(nameof(auditRepository));
            _ticketConfigurationRepository = ticketConfigurationRepository ?? throw new ArgumentNullException(nameof(ticketConfigurationRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<ApiResponse<LogViewModel>> Handle(GetAllLogsQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<LogViewModel>();
            var logToViewHelper = new LogToViewHelper(_identityService, _ticketConfigurationRepository);
            response.Data = new LogViewModel();

            var dbResult = await _auditRepository.ListAll(request.Page, request.Searchstring);
            response.Data.Logs = await AssignNameToUserId( _mapper.Map<List<AuditLogDto>>(dbResult));
            var logsCount = await GetLogCount(request.Searchstring);
            response.Data.Pager = new Pager(logsCount, request.Page);

            return response;
        }


        private async Task<int> GetLogCount(string searchString)
        {            
            return await _auditRepository.CountAll(searchString);
        }

        private async Task<List<AuditLogDto>> AssignNameToUserId(List<AuditLogDto> logs)
        {
            foreach (var log in logs)
            {
                log.User = await _identityService.GetUserNameById(log.User);
            }
            return logs;
        }
    }
}
