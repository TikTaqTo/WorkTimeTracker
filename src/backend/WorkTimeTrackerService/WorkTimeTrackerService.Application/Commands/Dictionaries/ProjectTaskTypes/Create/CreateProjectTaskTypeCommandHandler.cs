using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskTypes.Create
{
  public class CreateProjectTaskTypeCommandHandler : IRequestHandler<CreateProjectTaskTypeCommand, ProjectTaskTypeReply>
  {
    private readonly IProjectTaskTypeService _projectTaskTypeService;

    public CreateProjectTaskTypeCommandHandler(IProjectTaskTypeService projectTaskTypeService)
    {
      _projectTaskTypeService = projectTaskTypeService;
    }

    public async Task<ProjectTaskTypeReply> Handle(CreateProjectTaskTypeCommand request, CancellationToken cancellationToken)
    {
      return await _projectTaskTypeService.CreateProjectTaskType(request.ProjectTaskType);
    }
  }
}
