using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Projects;
using WorkTimeTrackerService.Domain.Replies.Projects;

namespace WorkTimeTrackerService.Application.Commands.Projects.AddProjectTask
{
  public class AddProjectTaskToProjectCommandHandler : IRequestHandler<AddProjectTaskToProjectCommand, ProjectReply>
  {
    private readonly IProjectService _projectService;

    public AddProjectTaskToProjectCommandHandler(IProjectService projectService)
    {
      _projectService = projectService;
    }

    public async Task<ProjectReply> Handle(AddProjectTaskToProjectCommand request, CancellationToken cancellationToken)
    {
      return await _projectService.AddTaskToProject(request.Request);
    }
  }
}
