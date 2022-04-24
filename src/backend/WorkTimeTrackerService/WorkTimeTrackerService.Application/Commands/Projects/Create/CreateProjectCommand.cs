using MediatR;
using WorkTimeTrackerService.Domain.EntityModels.Projects;
using WorkTimeTrackerService.Domain.Replies.Projects;

namespace WorkTimeTrackerService.Application.Commands.Projects.Create
{
  public class CreateProjectCommand : IRequest<ProjectReply>
  {
    public Project Project { get; }

    public CreateProjectCommand(Project project)
    {
      Project = project;
    }
  }
}
