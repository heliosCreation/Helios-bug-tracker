using AutoMapper;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Dto.UserManagement;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.UserManagement.GetAllRoles
{
    public class GetAllRolesQueryHandler : IRequestHandler<GetAllRolesQuery, ApiResponse<RoleDto>>
    {
        private readonly IMapper _mapper;
        private readonly IIdentityService _identityService;

        public GetAllRolesQueryHandler(IMapper mapper, IIdentityService identityService)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
        }
        public async Task<ApiResponse<RoleDto>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<RoleDto>();
            var dbRoles = await _identityService.ListAllRoles();
            response.DataList = _mapper.Map<List<RoleDto>>(dbRoles);
            return response;
        }
    }
}
