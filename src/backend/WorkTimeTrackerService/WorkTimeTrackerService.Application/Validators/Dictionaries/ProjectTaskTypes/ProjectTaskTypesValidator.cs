using FluentValidation;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;

namespace WorkTimeTrackerService.Application.Validators.Dictionaries.ProjectTaskTypes
{
  class ProjectTaskTypesValidator : AbstractValidator<ProjectTaskType>
  {
    public ProjectTaskTypesValidator()
    {
      RuleFor(x => x.Type)
        .NotNull()
        .WithMessage("Project task type can not be null")
        .NotEmpty()
        .WithMessage("Project task type can not be empty")
        .MaximumLength(200)
        .WithMessage("Project task type can not more than 200 chars");
    }
  }
}
