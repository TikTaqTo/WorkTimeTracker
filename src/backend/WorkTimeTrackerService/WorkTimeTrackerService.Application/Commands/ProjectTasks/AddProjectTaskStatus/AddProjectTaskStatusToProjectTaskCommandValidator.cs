using FluentValidation;
using WorkTimeTrackerService.Application.Commands.ProjectTasks.AddProjectTaskStatus;
using WorkTimeTrackerService.Application.Validators.ProjectTasks.Requests;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTasks.AddProjectTaskStatus
{
  public class AddProjectTaskStatusToProjectTaskCommandValidator : AbstractValidator<AddProjectTaskStatusToProjectTaskCommand>
  {
    public AddProjectTaskStatusToProjectTaskCommandValidator()
    {
      RuleFor(x => x.Request)
        .SetValidator(new AddProjectTaskStatusToProjectTaskRequestValidator())
        .WithMessage("Invalid task or status entity");
    }
  }
}
