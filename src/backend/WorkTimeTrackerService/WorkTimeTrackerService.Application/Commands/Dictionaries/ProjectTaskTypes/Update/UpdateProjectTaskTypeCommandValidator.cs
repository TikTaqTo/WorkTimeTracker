using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Validators.Dictionaries.ProjectTaskTypes;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskTypes.Update
{
  public class UpdateProjectTaskTypeCommandValidator : AbstractValidator<UpdateProjectTaskTypeCommand>
  {
    public UpdateProjectTaskTypeCommandValidator()
    {
      RuleFor(x => x.ProjectTaskType)
        .SetValidator(new ProjectTaskTypesValidator())
        .WithMessage("Invalid project task type entity");
    }
  }
}
