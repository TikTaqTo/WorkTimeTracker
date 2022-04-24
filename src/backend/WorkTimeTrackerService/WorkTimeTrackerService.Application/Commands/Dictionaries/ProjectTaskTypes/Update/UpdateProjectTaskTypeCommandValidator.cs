using FluentValidation;
using WorkTimeTrackerService.Application.Validators.Dictionaries.ProjectTaskTypes;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskTypes.Update
{
  public class UpdateProjectTaskTypeCommandValidator : AbstractValidator<UpdateProjectTaskTypeCommand>
  {
    public UpdateProjectTaskTypeCommandValidator()
    {
      RuleFor(x => x.ProjectTaskType)
        .SetValidator(new ProjectTaskTypesValidator())
        .WithMessage("Invalid project task type entity");
    }
  }
}
