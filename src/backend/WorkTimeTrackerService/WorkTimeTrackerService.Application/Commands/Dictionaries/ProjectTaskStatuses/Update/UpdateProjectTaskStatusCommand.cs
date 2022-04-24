using MediatR;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskStatuses.Update
{
  public class UpdateProjectTaskStatusCommand : IRequest<ProjectTaskStatusReply>
  {
    public ProjectTaskStatus ProjectTaskStatus { get; }

    public UpdateProjectTaskStatusCommand(ProjectTaskStatus projectTaskStatus)
    {
      ProjectTaskStatus = projectTaskStatus;
    }
  }
}
