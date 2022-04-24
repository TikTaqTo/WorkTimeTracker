using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Projects;
using WorkTimeTrackerService.Domain.Replies.Projects;

namespace WorkTimeTrackerService.Application.Commands.Projects.Delete
{
  public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, ProjectReply>
  {
    private readonly IProjectService _projectService;

    public DeleteProjectCommandHandler(IProjectService projectService)
    {
      _projectService = projectService;
    }

    public async Task<ProjectReply> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
    {
      return await _projectService.DeleteProjectById(request.Id);
    }
  }
}
