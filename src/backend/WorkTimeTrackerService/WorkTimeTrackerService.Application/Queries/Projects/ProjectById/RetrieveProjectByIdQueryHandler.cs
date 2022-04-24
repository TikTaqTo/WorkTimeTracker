using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Projects;
using WorkTimeTrackerService.Domain.Replies.Projects;

namespace WorkTimeTrackerService.Application.Queries.Projects.ProjectById
{
  public class RetrieveProjectByIdQueryHandler : IRequestHandler<RetrieveProjectByIdQuery, ProjectReply>
  {
    private readonly IProjectService _projectService;

    public RetrieveProjectByIdQueryHandler(IProjectService projectService)
    {
      _projectService = projectService;
    }

    public async Task<ProjectReply> Handle(RetrieveProjectByIdQuery request, CancellationToken cancellationToken)
    {
      return await _projectService.RetrieveProjectById(request.Id);
    }
  }
}
