using MediatR;
using System;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Queries.Dictionaries.ProjectTasks.ProjectTasksByProjectId
{
  public class RetrieveProjectTasksByProjectIdQuery : IRequest<ProjectTasksReply>
  {
    public Guid Id { get; }

    public RetrieveProjectTasksByProjectIdQuery(Guid id)
    {
      Id = id;
    }
  }
}
