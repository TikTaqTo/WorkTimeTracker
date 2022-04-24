using FluentValidation;
using System;
using WorkTimeTrackerService.Domain.Requests;

namespace WorkTimeTrackerService.Application.Validators.ProjectTasks.Requests
{
  public class AddProjectTaskStatusToProjectTaskRequestValidator : AbstractValidator<AddProjectTaskStatusToProjectTaskRequest>
  {
    public AddProjectTaskStatusToProjectTaskRequestValidator()
    {
      RuleFor(x => x.ProjectTaskId)
        .NotEqual(Guid.Empty)
        .WithMessage("Project task Id cannot be empty");

      RuleFor(x => x.ProjectTaskStatusId)
        .NotEqual(Guid.Empty)
        .WithMessage("Task status Id cannot be empty");
    }
  }
}
