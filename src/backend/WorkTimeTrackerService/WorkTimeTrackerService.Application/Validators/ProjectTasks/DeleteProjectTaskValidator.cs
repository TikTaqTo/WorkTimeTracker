using FluentValidation;
using System;

namespace WorkTimeTrackerService.Application.Validators.ProjectTasks
{
  public class DeleteProjectTaskValidator : AbstractValidator<Guid>
  {
    public DeleteProjectTaskValidator()
    {
      RuleFor(x => x)
        .NotEqual(Guid.Empty)
        .WithMessage("Project Task Id cannot be empty");
    }
  }
}
