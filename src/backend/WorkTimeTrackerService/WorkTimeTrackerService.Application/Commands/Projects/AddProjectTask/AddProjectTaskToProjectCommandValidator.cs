﻿using FluentValidation;

namespace WorkTimeTrackerService.Application.Commands.Projects.AddProjectTask
{
  public class AddProjectTaskToProjectCommandValidator : AbstractValidator<AddProjectTaskToProjectCommand>
  {
    public AddProjectTaskToProjectCommandValidator()
    {
      RuleFor(x => x.Request)
        .SetValidator(new AddProjectTaskToProjectRequestValidator())
        .WithMessage("Invalid project or task entity");
    }
  }
}
