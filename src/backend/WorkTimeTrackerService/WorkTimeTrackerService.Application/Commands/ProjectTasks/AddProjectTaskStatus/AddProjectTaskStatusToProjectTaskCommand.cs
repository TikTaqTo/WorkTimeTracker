using MediatR;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;
using WorkTimeTrackerService.Domain.Requests;

namespace WorkTimeTrackerService.Application.Commands.ProjectTasks.AddProjectTaskStatus
{
  public class AddProjectTaskStatusToProjectTaskCommand : IRequest<ProjectTaskReply>
  {
    public AddProjectTaskStatusToProjectTaskRequest Request { get; }

    public AddProjectTaskStatusToProjectTaskCommand(AddProjectTaskStatusToProjectTaskRequest request)
    {
      Request = request;
    }
  }
}
