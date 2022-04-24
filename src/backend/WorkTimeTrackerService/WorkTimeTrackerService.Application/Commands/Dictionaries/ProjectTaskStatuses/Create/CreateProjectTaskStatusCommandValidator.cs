using FluentValidation;
using WorkTimeTrackerService.Application.Validators.Dictionaries.ProjectTaskStatuses;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskStatuses.Create
{
  public class CreateProjectTaskStatusCommandValidator : AbstractValidator<CreateProjectTaskStatusCommand>
  {
    public CreateProjectTaskStatusCommandValidator()
    {
      RuleFor(x => x.ProjectTaskStatus)
        .SetValidator(new ProjectTaskStatusesValidator())
        .WithMessage("Invalid project task status entity");
    }
  }
}
