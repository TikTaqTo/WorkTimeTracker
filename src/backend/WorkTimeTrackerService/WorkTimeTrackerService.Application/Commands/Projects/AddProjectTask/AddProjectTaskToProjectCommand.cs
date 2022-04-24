using MediatR;
using WorkTimeTrackerService.Domain.Replies.Projects;
using WorkTimeTrackerService.Domain.Requests;

namespace WorkTimeTrackerService.Application.Commands.Projects.AddProjectTask
{
  public class AddProjectTaskToProjectCommand : IRequest<ProjectReply>
  {
    public AddProjectTaskToProjectRequest Request { get; }

    public AddProjectTaskToProjectCommand(AddProjectTaskToProjectRequest request)
    {
      Request = request;
    }
  }
}
