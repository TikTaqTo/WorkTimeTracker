using MediatR;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Queries.Dictionaries.ProjectTasks.AllProjectTasks
{
  public class RetrieveProjectTasksQuery : IRequest<ProjectTasksReply>
  {
  }
}
