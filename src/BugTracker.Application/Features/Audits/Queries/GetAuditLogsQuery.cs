using BugTracker.Application.Dto.Audits;
using BugTracker.Application.Enums;
using BugTracker.Application.Model.Auditing;
using BugTracker.Application.Responses;
using MediatR;
using System;

namespace BugTracker.Application.Features.Audits.Queries
{
    public class GetAuditLogsQuery : IRequest<ApiResponse<AuditLogDto>>
    {
        public GetAuditLogsQuery(Guid id, AuditableType type)
        {
            Id = id;
            Type = type;
        }

        public Guid Id { get; }
        public AuditableType Type { get; }
    }
}
