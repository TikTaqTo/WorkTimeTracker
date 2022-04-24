using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.ProjectTasks;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Commands.ProjectTasks.Delete
{
  public class DeleteProjectTaskCommandHanlder : IRequestHandler<DeleteProjectTaskCommand, ProjectTaskReply>
  {
    private readonly IProjectTaskService _projectTaskService;

    public DeleteProjectTaskCommandHanlder(IProjectTaskService projectTaskService)
    {
      _projectTaskService = projectTaskService;
    }

    public async Task<ProjectTaskReply> Handle(DeleteProjectTaskCommand request, CancellationToken cancellationToken)
    {
      return await _projectTaskService.DeleteProjectTaskById(request.Id);
    }
  }
}
