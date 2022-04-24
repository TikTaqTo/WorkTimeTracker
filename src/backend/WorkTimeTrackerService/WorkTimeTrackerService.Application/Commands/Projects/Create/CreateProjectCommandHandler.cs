using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Projects;
using WorkTimeTrackerService.Domain.Replies.Projects;

namespace WorkTimeTrackerService.Application.Commands.Projects.Create
{
  public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, ProjectReply>
  {
    private readonly IProjectService _projectService;

    public CreateProjectCommandHandler(IProjectService projectService)
    {
      _projectService = projectService;
    }

    public async Task<ProjectReply> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
    {
      return await _projectService.CreateProject(request.Project);
    }
  }
}
