using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskTypes.Update
{
  public class UpdateProjectTaskTypeCommandHandler : IRequestHandler<UpdateProjectTaskTypeCommand, ProjectTaskTypeReply>
  {
    private readonly IProjectTaskTypeService _projectTaskTypeService;

    public UpdateProjectTaskTypeCommandHandler(IProjectTaskTypeService projectTaskTypeService)
    {
      _projectTaskTypeService = projectTaskTypeService;
    }

    public async Task<ProjectTaskTypeReply> Handle(UpdateProjectTaskTypeCommand request, CancellationToken cancellationToken)
    {
      return await _projectTaskTypeService.UpdateProjectTaskType(request.ProjectTaskType);
    }
  }
}
