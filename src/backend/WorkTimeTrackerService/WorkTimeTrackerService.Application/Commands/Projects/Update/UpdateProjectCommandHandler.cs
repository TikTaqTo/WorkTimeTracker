using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Projects;
using WorkTimeTrackerService.Domain.Replies.Projects;

namespace WorkTimeTrackerService.Application.Commands.Projects.Update
{
  public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, ProjectReply>
  {
    private readonly IProjectService _projectService;

    public UpdateProjectCommandHandler(IProjectService projectService)
    {
      _projectService = projectService;
    }

    public async Task<ProjectReply> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
    {
      return await _projectService.UpdateProject(request.Project);
    }
  }
}
