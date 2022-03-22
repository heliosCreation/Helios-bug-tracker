using AutoMapper;
using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Dto.Comments;
using BugTracker.Application.Responses;
using BugTracker.Domain.Entities;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Comments.Commands.Create
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, ApiResponse<CommentDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;
        private readonly ITicketRepository _ticketRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly ILoggedInUserService _loggedInUserService;

        public CreateCommentCommandHandler(IMapper mapper,
            ICommentRepository commentRepository,
            ITicketRepository ticketRepository,
            IProjectRepository projectRepository,
            ILoggedInUserService loggedInUserService)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _commentRepository = commentRepository ?? throw new ArgumentNullException(nameof(commentRepository));
            _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
            _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
            _loggedInUserService = loggedInUserService ?? throw new ArgumentNullException(nameof(loggedInUserService));
        }

        public async Task<ApiResponse<CommentDto>> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var response = new ApiResponse<CommentDto>();
            if (!await IsAllowedToAccessTickets(response, request.TicketId))
            {
                response.SetUnhautorizedResponse();
                return response;
            }
            var comment = _mapper.Map<Comment>(request);
            var createdComment = await _commentRepository.AddAsync(comment);
            response.Data = _mapper.Map<CommentDto>(createdComment);
            
            return response;
        }

        private async Task<bool> IsAllowedToAccessTickets(ApiResponse<CommentDto> response, Guid ticketId)
        {
            var isAdmin = _loggedInUserService.Roles.Contains("Admin");
            var isProjectManager = _loggedInUserService.Roles.Any(str => str == "Project Manager");
            var isSubmitter = _loggedInUserService.Roles.Any(str => str == "Submitter");

            if (isAdmin)
            {
                return true;
            }
            else if (isProjectManager || isSubmitter)
            {
                var projectId = await _projectRepository.GetProjectIdByTicketId(ticketId);
                return await _projectRepository.UserBelongsToProjectTeam(_loggedInUserService.UserId, projectId);
            }


            return await _ticketRepository.UserBelongsToTicketTeam(_loggedInUserService.UserId, ticketId);
        }
    }
}
