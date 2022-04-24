using MediatR;
using System;
using WorkTimeTrackerService.Domain.Replies.Projects;

namespace WorkTimeTrackerService.Application.Commands.Projects.Delete
{
  public class DeleteProjectCommand : IRequest<ProjectReply>
  {
    public Guid Id { get; }

    public DeleteProjectCommand(Guid id)
    {
      Id = id;
    }
  }
}
