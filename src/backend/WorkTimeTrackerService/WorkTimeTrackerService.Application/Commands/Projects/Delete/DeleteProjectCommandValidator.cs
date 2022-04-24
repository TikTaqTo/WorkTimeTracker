using FluentValidation;
using WorkTimeTrackerService.Application.Validators.Projects;

namespace WorkTimeTrackerService.Application.Commands.Projects.Delete
{
  public class DeleteProjectCommandValidator : AbstractValidator<DeleteProjectCommand>
  {
    public DeleteProjectCommandValidator()
    {
      RuleFor(x => x.Id)
        .SetValidator(new DeleteProjectValidator())
        .WithMessage("Invalid project id");
    }
  }
}
