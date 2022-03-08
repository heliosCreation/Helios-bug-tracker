using BugTracker.Application.Contracts.Audits;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Audits.Queries.GetAllLogs
{
    public class GetAllLogsQueryHandler : IRequestHandler<GetAllLogsQuery, ApiResponse<LogViewModel>>
    {
        private readonly IIdentityService _identityService;
        private readonly IAuditRepository _auditRepository;

        public GetAllLogsQueryHandler(IIdentityService identityService, IAuditRepository auditRepository)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _auditRepository = auditRepository ?? throw new ArgumentNullException(nameof(auditRepository));
        }
        public Task<ApiResponse<LogViewModel>> Handle(GetAllLogsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
