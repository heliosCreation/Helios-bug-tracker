using AutoMapper;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Team.Queries.GetAllAccessibleMembers
{
    public class GetAllAccessibleMembersQueryHandler : IRequestHandler<GetAllAccessibleMembersQuery, ApiResponse<UserViewModel>>
    {
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;

        public GetAllAccessibleMembersQueryHandler(ILoggedInUserService loggedInUserService, IIdentityService identityService,IMapper mapper)
        {
            _loggedInUserService = loggedInUserService ?? throw new ArgumentNullException(nameof(loggedInUserService));
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ApiResponse<UserViewModel>> Handle(GetAllAccessibleMembersQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<UserViewModel>();
            var uid = _loggedInUserService.UserId;

            response.DataList = _mapper.Map<List<UserViewModel>>(await _identityService.GetAllAccessibleUsers(uid));
            return response;
            
        }
    }
}
