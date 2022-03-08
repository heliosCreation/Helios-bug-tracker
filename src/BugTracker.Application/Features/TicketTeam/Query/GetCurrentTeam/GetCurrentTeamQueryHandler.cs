using AutoMapper;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Responses;
using BugTracker.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.TicketTeam.Query.GetCurrentTeam
{
    public class GetCurrentTeamQueryHandler : IRequestHandler<GetCurrentTeamQuery, ApiResponse<UserViewModel>>
    {
        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;

        public GetCurrentTeamQueryHandler(IIdentityService identityService, IMapper mapper)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<ApiResponse<UserViewModel>> Handle(GetCurrentTeamQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<UserViewModel>();

            var ticketTeam = _mapper.Map<List<UserViewModel>>(await _identityService.GetCurrentTicketTeam(request.TicketId));
            foreach (var user in ticketTeam)
            {
                var roles = await _identityService.GetUserRolesById(user.Id.ToString());
                if (roles.Any())
                {
                    user.Role = roles.Select(r => r.Name).ToList()[0];
                    response.DataList.Add(user);
                }
            }
            response.DataList = response.DataList.OrderBy(tm => tm.Role).ToList();

            return response;
        }
    }
}
