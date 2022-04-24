using FluentValidation;
using System;

namespace WorkTimeTrackerService.Application.Validators.Projects
{
  public class DeleteProjectValidator : AbstractValidator<Guid>
  {
    public DeleteProjectValidator()
    {
      RuleFor(x => x)
        .NotEqual(Guid.Empty)
        .WithMessage("Project Id cannot be empty");
    }
  }
}
