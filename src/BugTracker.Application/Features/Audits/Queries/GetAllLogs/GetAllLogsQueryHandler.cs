using AutoMapper;
using BugTracker.Application.Contracts.Audits;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Dto.Audits;
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
        private readonly IMapper _mapper;

        public GetAllLogsQueryHandler(IIdentityService identityService, IAuditRepository auditRepository, IMapper mapper)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _auditRepository = auditRepository ?? throw new ArgumentNullException(nameof(auditRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<ApiResponse<LogViewModel>> Handle(GetAllLogsQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<LogViewModel>();
            response.Data = new LogViewModel();

            var dbResult = await _auditRepository.ListAll();
            response.Data.Logs = _mapper.Map<List<AuditLogDto>>(dbResult);

            return response;
        }
    }
}
