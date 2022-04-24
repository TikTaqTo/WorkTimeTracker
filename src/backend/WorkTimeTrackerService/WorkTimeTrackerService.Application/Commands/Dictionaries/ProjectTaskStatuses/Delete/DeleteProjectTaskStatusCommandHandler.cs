using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskStatuses.Delete
{
  public class DeleteProjectTaskStatusCommandHandler : IRequestHandler<DeleteProjectTaskStatusCommand, ProjectTaskStatusReply>
  {
    private readonly IProjectTaskStatusService _projectTaskStatusService;

    public DeleteProjectTaskStatusCommandHandler(IProjectTaskStatusService projectTaskStatusService)
    {
      _projectTaskStatusService = projectTaskStatusService;
    }

    public async Task<ProjectTaskStatusReply> Handle(DeleteProjectTaskStatusCommand request, CancellationToken cancellationToken)
    {
      return await _projectTaskStatusService.DeleteProjectTaskStatusById(request.Id);
    }
  }
}
