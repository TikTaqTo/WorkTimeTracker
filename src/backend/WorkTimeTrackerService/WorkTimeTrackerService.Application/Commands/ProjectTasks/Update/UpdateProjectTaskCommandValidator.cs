﻿using FluentValidation;

namespace WorkTimeTrackerService.Application.Commands.ProjectTasks.Update
{
  public class UpdateProjectTaskCommandValidator : AbstractValidator<UpdateProjectTaskCommand>
  {
    public UpdateProjectTaskCommandValidator()
    {
      RuleFor(x => x.ProjectTask)
        .SetValidator(new ProjectTaskValidator())
        .WithMessage("Invalid project task entity");
    }
  }
}
