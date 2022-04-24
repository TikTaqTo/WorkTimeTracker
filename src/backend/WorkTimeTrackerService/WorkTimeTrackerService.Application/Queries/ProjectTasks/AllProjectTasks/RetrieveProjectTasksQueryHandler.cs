using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.ProjectTasks;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Queries.Dictionaries.ProjectTasks.AllProjectTasks
{
  public class RetrieveProjectTasksQueryHandler : IRequestHandler<RetrieveProjectTasksQuery, ProjectTasksReply>
  {
    private readonly IProjectTaskService _projectTaskService;

    public RetrieveProjectTasksQueryHandler(IProjectTaskService projectTaskService)
    {
      _projectTaskService = projectTaskService;
    }

    public async Task<ProjectTasksReply> Handle(RetrieveProjectTasksQuery request, CancellationToken cancellationToken)
    {
      return await _projectTaskService.RetrieveProjectTasks();
    }
  }
}
