using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Queries.Dictionaries.ProjectTaskStatuses
{
  public class RetrieveProjectTaskStatusesQueryHandler : IRequestHandler<RetrieveProjectTaskStatusesQuery, ProjectTaskStatusesReply>
  {
    private readonly IProjectTaskStatusService _projectTaskStatusService;

    public RetrieveProjectTaskStatusesQueryHandler(IProjectTaskStatusService projectTaskStatusService)
    {
      _projectTaskStatusService = projectTaskStatusService;
    }

    public async Task<ProjectTaskStatusesReply> Handle(RetrieveProjectTaskStatusesQuery request, CancellationToken cancellationToken)
    {
      return await _projectTaskStatusService.RetrieveProjectTaskStatuses();
    }
  }
}
