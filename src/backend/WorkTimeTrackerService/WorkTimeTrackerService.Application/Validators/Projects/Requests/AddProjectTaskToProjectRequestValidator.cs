using FluentValidation;
using System;
using WorkTimeTrackerService.Domain.Requests;

namespace WorkTimeTrackerService.Application.Validators.Projects.Requests
{
  public class AddProjectTaskToProjectRequestValidator : AbstractValidator<AddProjectTaskToProjectRequest>
  {
    public AddProjectTaskToProjectRequestValidator()
    {
      RuleFor(x => x.ProjectId)
        .NotEqual(Guid.Empty)
        .WithMessage("Project Id cannot be empty");

      RuleFor(x => x.ProjectTaskId)
        .NotEqual(Guid.Empty)
        .WithMessage("Project Task Id cannot be empty");
    }
  }
}
