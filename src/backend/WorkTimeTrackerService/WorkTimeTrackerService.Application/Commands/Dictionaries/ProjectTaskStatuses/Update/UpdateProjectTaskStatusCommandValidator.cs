using FluentValidation;
using WorkTimeTrackerService.Application.Validators.Dictionaries.ProjectTaskStatuses;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskStatuses.Update
{
  public class UpdateProjectTaskStatusCommandValidator : AbstractValidator<UpdateProjectTaskStatusCommand>
  {
    public UpdateProjectTaskStatusCommandValidator()
    {
      RuleFor(x => x.ProjectTaskStatus)
        .SetValidator(new ProjectTaskStatusesValidator())
        .WithMessage("Invalid project task status entity");
    }
  }
}
