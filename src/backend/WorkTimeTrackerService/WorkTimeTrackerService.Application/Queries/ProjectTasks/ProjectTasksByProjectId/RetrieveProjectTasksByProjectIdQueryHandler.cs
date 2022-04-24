using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.ProjectTasks;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Queries.Dictionaries.ProjectTasks.ProjectTasksByProjectId
{
  public class RetrieveProjectTasksByProjectIdQueryHandler : IRequestHandler<RetrieveProjectTasksByProjectIdQuery, ProjectTasksReply>
  {
    private readonly IProjectTaskService _projectTaskService;

    public RetrieveProjectTasksByProjectIdQueryHandler(IProjectTaskService projectTaskService)
    {
      _projectTaskService = projectTaskService;
    }

    public async Task<ProjectTasksReply> Handle(RetrieveProjectTasksByProjectIdQuery request, CancellationToken cancellationToken)
    {
      return await _projectTaskService.RetrieveProjectTasksByProjectId(request.Id);
    }
  }
}
