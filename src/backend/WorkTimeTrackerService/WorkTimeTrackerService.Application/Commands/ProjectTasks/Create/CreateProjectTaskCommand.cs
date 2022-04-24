using MediatR;
using WorkTimeTrackerService.Domain.EntityModels.ProjectTasks;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Commands.ProjectTasks.Create
{
  public class CreateProjectTaskCommand : IRequest<ProjectTaskReply>
  {
    public ProjectTask ProjectTask { get; }

    public CreateProjectTaskCommand(ProjectTask projectTask)
    {
      ProjectTask = projectTask;
    }
  }
}
