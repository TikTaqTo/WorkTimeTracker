using FluentValidation;
using System;

namespace WorkTimeTrackerService.Application.Validators.Dictionaries.ProjectTaskStatuses
{
  public class DeleteProjectTaskStatusValidator : AbstractValidator<Guid>
  {
    public DeleteProjectTaskStatusValidator()
    {
      RuleFor(x => x)
        .NotEqual(Guid.Empty)
        .WithMessage("Project Task Id cannot be empty");
    }
  }
}
