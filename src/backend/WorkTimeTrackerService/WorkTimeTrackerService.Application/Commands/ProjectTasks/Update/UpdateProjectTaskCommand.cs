using MediatR;
using WorkTimeTrackerService.Domain.EntityModels.ProjectTasks;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Commands.ProjectTasks.Update
{
  public class UpdateProjectTaskCommand : IRequest<ProjectTaskReply>
  {
    public ProjectTask ProjectTask { get; }

    public UpdateProjectTaskCommand(ProjectTask projectTask)
    {
      ProjectTask = projectTask;
    }
  }
}
