using MediatR;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskTypes.Update
{
  public class UpdateProjectTaskTypeCommand : IRequest<ProjectTaskTypeReply>
  {
    public ProjectTaskType ProjectTaskType { get; }

    public UpdateProjectTaskTypeCommand(ProjectTaskType projectTaskType)
    {
      ProjectTaskType = projectTaskType;
    }
  }
}
