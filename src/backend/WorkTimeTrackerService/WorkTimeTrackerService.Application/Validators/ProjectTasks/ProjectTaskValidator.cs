using FluentValidation;
using System;
using WorkTimeTrackerService.Domain.EntityModels.ProjectTasks;

namespace WorkTimeTrackerService.Application.Validators.ProjectTasks
{
  public class ProjectTaskValidator : AbstractValidator<ProjectTask>
  {
    public ProjectTaskValidator()
    {
      RuleFor(x => x.Title)
        .NotNull()
        .WithMessage("Project task title can not be null")
        .NotEmpty()
        .WithMessage("Project task title can not be empty")
        .MaximumLength(200)
        .WithMessage("Project task title can not more than 200 chars");

      RuleFor(x => x.Description)
        .MaximumLength(1000)
        .WithMessage("Project task description can not more than 1000 chars");

      RuleFor(x => x.ProjectId)
        .NotEqual(Guid.Empty)
        .WithMessage("Project Task Id cannot be empty");
    }
  }
}
