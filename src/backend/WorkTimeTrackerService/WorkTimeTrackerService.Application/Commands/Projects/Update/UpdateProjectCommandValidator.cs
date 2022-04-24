using FluentValidation;
using WorkTimeTrackerService.Application.Validators.Projects;

namespace WorkTimeTrackerService.Application.Commands.Projects.Update
{
  public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
  {
    public UpdateProjectCommandValidator()
    {
      RuleFor(x => x.Project)
        .SetValidator(new ProjectValidator())
        .WithMessage("Invalid project entity");
    }
  }
}
