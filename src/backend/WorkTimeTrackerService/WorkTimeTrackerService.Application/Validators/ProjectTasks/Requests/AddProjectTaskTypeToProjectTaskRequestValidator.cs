using FluentValidation;
using System;
using WorkTimeTrackerService.Domain.Requests;

namespace WorkTimeTrackerService.Application.Validators.ProjectTasks.Requests
{
  public class AddProjectTaskTypeToProjectTaskRequestValidator : AbstractValidator<AddProjectTaskTypeToProjectTaskRequest>
  {
    public AddProjectTaskTypeToProjectTaskRequestValidator()
    {
      RuleFor(x => x.ProjectTaskId)
        .NotEqual(Guid.Empty)
        .WithMessage("Project task Id cannot be empty");

      RuleFor(x => x.ProjectTaskTypeId)
        .NotEqual(Guid.Empty)
        .WithMessage("Task type Id cannot be empty");
    }
  }
}
