using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Projects;
using WorkTimeTrackerService.Domain.Replies.Projects;

namespace WorkTimeTrackerService.Application.Queries.Projects.AllProjects
{
  public class RetrieveProjectsQueryHandler : IRequestHandler<RetrieveProjectsQuery, ProjectsReply>
  {
    private readonly IProjectService _projectService;

    public RetrieveProjectsQueryHandler(IProjectService projectService)
    {
      _projectService = projectService;
    }

    public async Task<ProjectsReply> Handle(RetrieveProjectsQuery request, CancellationToken cancellationToken)
    {
      return await _projectService.RetrieveProjects();
    }
  }
}
