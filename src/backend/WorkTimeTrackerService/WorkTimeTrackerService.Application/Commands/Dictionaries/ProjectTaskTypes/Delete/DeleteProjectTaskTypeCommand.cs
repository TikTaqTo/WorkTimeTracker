using MediatR;
using System;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskTypes.Delete
{
  public class DeleteProjectTaskTypeCommand : IRequest<ProjectTaskTypeReply>
  {
    public Guid Id { get; }

    public DeleteProjectTaskTypeCommand(Guid id)
    {
      Id = id;
    }
  }
}
