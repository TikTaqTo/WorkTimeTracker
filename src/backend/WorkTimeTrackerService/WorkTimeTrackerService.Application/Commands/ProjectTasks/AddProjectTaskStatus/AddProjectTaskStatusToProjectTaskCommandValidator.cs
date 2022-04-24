using FluentValidation;

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
