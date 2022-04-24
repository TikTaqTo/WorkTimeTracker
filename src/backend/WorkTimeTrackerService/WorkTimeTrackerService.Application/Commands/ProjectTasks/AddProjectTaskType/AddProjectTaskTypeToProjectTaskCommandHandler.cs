using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.ProjectTasks;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Commands.ProjectTasks.AddProjectTaskType
{
  public class AddProjectTaskTypeToProjectTaskCommandHandler : IRequestHandler<AddProjectTaskTypeToProjectTaskCommand, ProjectTaskReply>
  {
    private readonly IProjectTaskService _projectTaskService;

    public AddProjectTaskTypeToProjectTaskCommandHandler(IProjectTaskService projectTaskService)
    {
      _projectTaskService = projectTaskService;
    }

    public async Task<ProjectTaskReply> Handle(AddProjectTaskTypeToProjectTaskCommand request, CancellationToken cancellationToken)
    {
      return await _projectTaskService.AddProjectTaskTypeToProjectTask(request.Request);
    }
  }
}
