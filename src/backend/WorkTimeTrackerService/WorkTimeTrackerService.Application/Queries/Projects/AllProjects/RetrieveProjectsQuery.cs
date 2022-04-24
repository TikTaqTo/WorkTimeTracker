using MediatR;
using WorkTimeTrackerService.Domain.Replies.Projects;

namespace WorkTimeTrackerService.Application.Queries.Projects.AllProjects
{
  public class RetrieveProjectsQuery : IRequest<ProjectsReply>
  {
  }
}
