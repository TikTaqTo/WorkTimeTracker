using MediatR;
using WorkTimeTrackerService.Domain.EntityModels.Projects;
using WorkTimeTrackerService.Domain.Replies.Projects;

namespace WorkTimeTrackerService.Application.Commands.Projects.Update
{
  public class UpdateProjectCommand : IRequest<ProjectReply>
  {
    public Project Project { get; }

    public UpdateProjectCommand(Project project)
    {
      Project = project;
    }
  }
}
