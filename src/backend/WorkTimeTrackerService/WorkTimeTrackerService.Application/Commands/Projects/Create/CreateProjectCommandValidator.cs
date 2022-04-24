using FluentValidation;
using WorkTimeTrackerService.Application.Validators.Projects;

namespace WorkTimeTrackerService.Application.Commands.Projects.Create
{
  public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
  {
    public CreateProjectCommandValidator()
    {
      RuleFor(x => x.Project)
        .SetValidator(new ProjectValidator())
        .WithMessage("Invalid project entity");
    }
  }
}
