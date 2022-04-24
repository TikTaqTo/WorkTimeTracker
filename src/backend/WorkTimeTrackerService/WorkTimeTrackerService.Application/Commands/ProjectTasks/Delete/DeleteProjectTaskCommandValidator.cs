﻿using FluentValidation;
using WorkTimeTrackerService.Application.Validators.ProjectTasks;

namespace WorkTimeTrackerService.Application.Commands.ProjectTasks.Delete
{
  public class DeleteProjectTaskCommandValidator : AbstractValidator<DeleteProjectTaskCommand>
  {
    public DeleteProjectTaskCommandValidator()
    {
      RuleFor(x => x.Id)
        .SetValidator(new DeleteProjectTaskValidator())
        .WithMessage("Invalid project task id");
    }
  }
}
