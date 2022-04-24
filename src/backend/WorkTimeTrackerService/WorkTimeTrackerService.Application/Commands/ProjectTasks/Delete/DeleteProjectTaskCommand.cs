using MediatR;
using System;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Commands.ProjectTasks.Delete
{
  public class DeleteProjectTaskCommand : IRequest<ProjectTaskReply>
  {
    public Guid Id { get; }

    public DeleteProjectTaskCommand(Guid id)
    {
      Id = id;
    }
  }
}
