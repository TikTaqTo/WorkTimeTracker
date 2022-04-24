using FluentValidation;
using WorkTimeTrackerService.Domain.EntityModels.Projects;

namespace WorkTimeTrackerService.Application.Validators.Projects
{
  public class ProjectValidator : AbstractValidator<Project>
  {
    public ProjectValidator()
    {
      RuleFor(x => x.Title)
        .NotNull()
        .WithMessage("Project title can not be null")
        .NotEmpty()
        .WithMessage("Project title can not be empty")
        .MaximumLength(200)
        .WithMessage("Project title can not more than 200 chars");

      RuleFor(x => x.Description)
        .MaximumLength(1000)
        .WithMessage("Project description can not more than 1000 chars");
    }
  }
}
