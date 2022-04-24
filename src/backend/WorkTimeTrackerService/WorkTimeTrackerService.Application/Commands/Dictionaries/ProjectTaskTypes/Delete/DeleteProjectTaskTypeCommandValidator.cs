using FluentValidation;
using WorkTimeTrackerService.Application.Validators.Dictionaries.ProjectTaskTypes;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskTypes.Delete
{
  public class DeleteProjectTaskTypeCommandValidator : AbstractValidator<DeleteProjectTaskTypeCommand>
  {
    public DeleteProjectTaskTypeCommandValidator()
    {
      RuleFor(x => x.Id)
        .SetValidator(new DeleteProjectTaskTypesValidator())
        .WithMessage("Invalid project task type entity");
    }
  }
}
