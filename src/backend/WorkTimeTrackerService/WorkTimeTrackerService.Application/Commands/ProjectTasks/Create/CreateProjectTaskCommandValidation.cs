using FluentValidation;

namespace WorkTimeTrackerService.Application.Commands.ProjectTasks.Create
{
  public class CreateProjectTaskCommandValidation : AbstractValidator<CreateProjectTaskCommand>
  {
    public CreateProjectTaskCommandValidation()
    {
      RuleFor(x => x.ProjectTask)
        .SetValidator(new ProjectTaskValidator())
        .WithMessage("Invalid project task entity");
    }
  }
}
