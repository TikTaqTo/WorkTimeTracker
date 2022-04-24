using MediatR;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskTypes.Create
{
  public class CreateProjectTaskTypeCommand : IRequest<ProjectTaskTypeReply>
  {
    public ProjectTaskType ProjectTaskType { get; }

    public CreateProjectTaskTypeCommand(ProjectTaskType projectTaskType)
    {
      ProjectTaskType = projectTaskType;
    }
  }
}
