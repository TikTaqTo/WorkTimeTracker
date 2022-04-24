using FluentValidation;
using System;

namespace WorkTimeTrackerService.Application.Validators.Dictionaries.ProjectTaskTypes
{
  public class DeleteProjectTaskTypesValidator : AbstractValidator<Guid>
  {
    public DeleteProjectTaskTypesValidator()
    {
      RuleFor(x => x)
        .NotEqual(Guid.Empty)
        .WithMessage("Project Task Id cannot be empty");
    }
  }
}
