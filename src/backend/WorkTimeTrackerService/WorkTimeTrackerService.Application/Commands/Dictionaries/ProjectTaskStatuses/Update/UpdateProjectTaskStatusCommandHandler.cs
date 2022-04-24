using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskStatuses.Update
{
  public class UpdateProjectTaskStatusCommandHandler : IRequestHandler<UpdateProjectTaskStatusCommand, ProjectTaskStatusReply>
  {
    private readonly IProjectTaskStatusService _projectTaskStatusService;

    public UpdateProjectTaskStatusCommandHandler(IProjectTaskStatusService projectTaskStatusService)
    {
      _projectTaskStatusService = projectTaskStatusService;
    }

    public async Task<ProjectTaskStatusReply> Handle(UpdateProjectTaskStatusCommand request, CancellationToken cancellationToken)
    {
      return await _projectTaskStatusService.UpdateProjectTaskStatus(request.ProjectTaskStatus);
    }
  }
}
