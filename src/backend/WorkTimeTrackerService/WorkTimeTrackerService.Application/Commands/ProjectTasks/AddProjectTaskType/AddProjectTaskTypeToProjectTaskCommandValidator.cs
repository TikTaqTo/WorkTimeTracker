using FluentValidation;
using WorkTimeTrackerService.Application.Commands.ProjectTasks.AddProjectTaskType;
using WorkTimeTrackerService.Application.Validators.ProjectTasks.Requests;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTasks.AddProjectTaskType
{
  public class AddProjectTaskTypeToProjectTaskCommandValidator : AbstractValidator<AddProjectTaskTypeToProjectTaskCommand>
  {
    public AddProjectTaskTypeToProjectTaskCommandValidator()
    {
      RuleFor(x => x.Request)
        .SetValidator(new AddProjectTaskTypeToProjectTaskRequestValidator())
        .WithMessage("Invalid task or type entity");
    }
  }
}
