using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.ProjectTasks;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Commands.ProjectTasks.Create
{
  public class CreateProjectTaskCommandHandler : IRequestHandler<CreateProjectTaskCommand, ProjectTaskReply>
  {
    private readonly IProjectTaskService _projectTaskService;

    public CreateProjectTaskCommandHandler(IProjectTaskService projectTaskService)
    {
      _projectTaskService = projectTaskService;
    }

    public async Task<ProjectTaskReply> Handle(CreateProjectTaskCommand request, CancellationToken cancellationToken)
    {
      return await _projectTaskService.CreateProjectTask(request.ProjectTask);
    }
  }
}
