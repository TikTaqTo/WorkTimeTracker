

using FluentValidation;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskTypes.Create
{
  public class CreateProjectTaskTypeCommandValidator : AbstractValidator<CreateProjectTaskTypeCommand>
  {
    public CreateProjectTaskTypeCommandValidator()
    {
      RuleFor(x => x.ProjectTaskType)
        .SetValidator(new ProjectTaskTypesValidator())
        .WithMessage("Invalid project task type entity");
    }
  }
}
