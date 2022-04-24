using MediatR;
using System;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Queries.Dictionaries.ProjectTasks.ProjectTaskById
{
  public class RetrieveProjectTaskByIdQuery : IRequest<ProjectTaskReply>
  {
    public Guid Id { get; }

    public RetrieveProjectTaskByIdQuery(Guid id)
    {
      Id = id;
    }
  }
}
