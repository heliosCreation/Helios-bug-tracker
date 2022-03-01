using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Dto.Comments;
using BugTracker.Application.Responses;
using BugTracker.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Comments.Commands.Create
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, ApiResponse<CommentDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;

        public CreateCommentCommandHandler(IMapper mapper, ICommentRepository commentRepository)
        {
            _mapper = mapper ?? throw new System.ArgumentNullException(nameof(mapper));
            _commentRepository = commentRepository ?? throw new System.ArgumentNullException(nameof(commentRepository));
        }

        public async Task<ApiResponse<CommentDto>> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<CommentDto>();

            var comment = _mapper.Map<Comment>(request);
            var createdComment = await _commentRepository.AddAsync(comment);
            response.Data = _mapper.Map<CommentDto>(createdComment);
            
            return response;
        }
    }
}
