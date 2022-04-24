using FluentValidation;
using WorkTimeTrackerService.Application.Validators.Dictionaries.ProjectTaskStatuses;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskStatuses.Delete
{
  public class DeleteProjectTaskStatusCommandValidator : AbstractValidator<DeleteProjectTaskStatusCommand>
  {
    public DeleteProjectTaskStatusCommandValidator()
    {
      RuleFor(x => x.Id)
        .SetValidator(new DeleteProjectTaskStatusValidator())
        .WithMessage("Invalid project task status id");
    }
  }
}
