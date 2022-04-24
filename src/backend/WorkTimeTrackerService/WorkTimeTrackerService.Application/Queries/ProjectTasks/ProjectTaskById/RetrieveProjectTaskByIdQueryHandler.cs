using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.ProjectTasks;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Queries.Dictionaries.ProjectTasks.ProjectTaskById
{
  public class RetrieveProjectTaskByIdQueryHandler : IRequestHandler<RetrieveProjectTaskByIdQuery, ProjectTaskReply>
  {
    private readonly IProjectTaskService _projectTaskService;

    public RetrieveProjectTaskByIdQueryHandler(IProjectTaskService projectTaskService)
    {
      _projectTaskService = projectTaskService;
    }

    public async Task<ProjectTaskReply> Handle(RetrieveProjectTaskByIdQuery request, CancellationToken cancellationToken)
    {
      return await _projectTaskService.RetrieveProjectTaskById(request.Id);
    }
  }
}
