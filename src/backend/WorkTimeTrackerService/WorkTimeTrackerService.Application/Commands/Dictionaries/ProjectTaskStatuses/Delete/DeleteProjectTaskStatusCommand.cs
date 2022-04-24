using MediatR;
using System;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskStatuses.Delete
{
  public class DeleteProjectTaskStatusCommand : IRequest<ProjectTaskStatusReply>
  {
    public Guid Id { get; }

    public DeleteProjectTaskStatusCommand(Guid id)
    {
      Id = id;
    }
  }
}
