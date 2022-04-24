using MediatR;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;
using WorkTimeTrackerService.Domain.Requests;

namespace WorkTimeTrackerService.Application.Commands.ProjectTasks.AddProjectTaskType
{
  public class AddProjectTaskTypeToProjectTaskCommand : IRequest<ProjectTaskReply>
  {
    public AddProjectTaskTypeToProjectTaskRequest Request { get; }

    public AddProjectTaskTypeToProjectTaskCommand(AddProjectTaskTypeToProjectTaskRequest request)
    {
      Request = request;
    }
  }
}
