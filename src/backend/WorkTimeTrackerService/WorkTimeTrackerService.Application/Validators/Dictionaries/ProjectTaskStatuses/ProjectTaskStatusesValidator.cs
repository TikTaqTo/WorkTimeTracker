using FluentValidation;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;

namespace WorkTimeTrackerService.Application.Validators.Dictionaries.ProjectTaskStatuses
{
  public class ProjectTaskStatusesValidator : AbstractValidator<ProjectTaskStatus>
  {
    public ProjectTaskStatusesValidator()
    {
      RuleFor(x => x.Status)
        .NotNull()
        .WithMessage("Project task status can not be null")
        .NotEmpty()
        .WithMessage("Project task status can not be empty")
        .MaximumLength(200)
        .WithMessage("Project task status can not more than 200 chars");
    }
  }
}
