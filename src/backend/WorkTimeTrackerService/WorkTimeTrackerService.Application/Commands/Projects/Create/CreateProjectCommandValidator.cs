using FluentValidation;

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
