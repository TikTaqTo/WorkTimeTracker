using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskStatuses.Create
{
  public class CreateProjectTaskStatusCommandHandler : IRequestHandler<CreateProjectTaskStatusCommand, ProjectTaskStatusReply>
  {
    private readonly IProjectTaskStatusService _projectTaskStatusService;

    public CreateProjectTaskStatusCommandHandler(IProjectTaskStatusService projectTaskStatusService)
    {
      _projectTaskStatusService = projectTaskStatusService;
    }

    public async Task<ProjectTaskStatusReply> Handle(CreateProjectTaskStatusCommand request, CancellationToken cancellationToken)
    {
      return await _projectTaskStatusService.CreateProjectTaskStatus(request.ProjectTaskStatus);
    }
  }
}
