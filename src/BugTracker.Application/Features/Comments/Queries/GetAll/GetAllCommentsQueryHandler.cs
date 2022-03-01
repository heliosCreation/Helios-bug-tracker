using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Dto.Comments;
using BugTracker.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Comments.Queries.GetAll
{
    public class GetAllCommentsQueryHandler : IRequestHandler<GetAllCommentsQuery, ApiResponse<CommentDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;
        private readonly IIdentityService _identityService;

        public GetAllCommentsQueryHandler(IMapper mapper, ICommentRepository commentRepository, IIdentityService identityService)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _commentRepository = commentRepository ?? throw new ArgumentNullException(nameof(commentRepository));
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
        }

        public async Task<ApiResponse<CommentDto>> Handle(GetAllCommentsQuery request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<CommentDto>();

            var dbResult = await _commentRepository.GetByTicket(request.TicketId);
            var comments = _mapper.Map<List<CommentDto>>(dbResult);

            foreach (var comment in comments)
            {
                comment.User = await _identityService.GetUserNameById(comment.User);
            }
            response.DataList = comments;
            return response;
        }
    }
}
