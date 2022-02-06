using BugTracker.Application.Contracts.Data;
using BugTracker.Application.Contracts.Identity;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BugTracker.Application.Features.Projects.Commands.Update
{
    public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IIdentityService _identityService;

        public UpdateProjectCommandValidator(IProjectRepository projectRepository, IIdentityService identityService)
        {
            _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));


            RuleFor(p => p.Name)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required")
                .MaximumLength(30).WithMessage("{PropertyName} can't exceed 30 characters.");

            RuleFor(p => p.Description)
                .MaximumLength(100).WithMessage("{PropertyName} can't exceed 100 characters.");

            RuleFor(e => e)
                .MustAsync(NameIsUnique).WithMessage("A category with the same given name already exists.")
                .MustAsync(UserIdsAreValid).WithMessage("One of the selected user, does not hold a valid Id");
        }

        private async Task<bool> NameIsUnique(UpdateProjectCommand e, CancellationToken c)
        {
            return await _projectRepository.NameIsUnique(e.Name);
        }

        private async Task<bool> UserIdsAreValid(UpdateProjectCommand e, CancellationToken c)
        {
            foreach (var Id in e.Team)
            {
                if (!await _identityService.UserEmailExist(Id.ToString()))
                {
                    return false;
                }
            }

            return true;
        }

    }
}
