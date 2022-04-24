using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.ProjectTasks;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Commands.ProjectTasks.AddProjectTaskStatus
{
  public class AddProjectTaskStatusToProjectTaskCommandHandler : IRequestHandler<AddProjectTaskStatusToProjectTaskCommand, ProjectTaskReply>
  {
    private readonly IProjectTaskService _projectTaskService;

    public AddProjectTaskStatusToProjectTaskCommandHandler(IProjectTaskService projectTaskService)
    {
      _projectTaskService = projectTaskService;
    }

    public async Task<ProjectTaskReply> Handle(AddProjectTaskStatusToProjectTaskCommand request, CancellationToken cancellationToken)
    {
      return await _projectTaskService.AddProjectTaskStatusToProjectTask(request.Request);
    }
  }
}
