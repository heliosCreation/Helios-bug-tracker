using FluentValidation;

namespace BugTracker.Application.Features.Comments.Commands.Create
{
    public class CreateCommentCommandValidator : AbstractValidator<CreateCommentCommand>
    {
        public CreateCommentCommandValidator()
        {
            RuleFor(c => c.Message)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);

        }
    }
}
