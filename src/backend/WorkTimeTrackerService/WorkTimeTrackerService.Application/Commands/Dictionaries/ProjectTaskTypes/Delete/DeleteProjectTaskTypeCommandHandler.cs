using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskTypes.Delete
{
  public class DeleteProjectTaskTypeCommandHandler : IRequestHandler<DeleteProjectTaskTypeCommand, ProjectTaskTypeReply>
  {
    private readonly IProjectTaskTypeService _projectTaskTypeService;

    public DeleteProjectTaskTypeCommandHandler(IProjectTaskTypeService projectTaskTypeService)
    {
      _projectTaskTypeService = projectTaskTypeService;
    }

    public async Task<ProjectTaskTypeReply> Handle(DeleteProjectTaskTypeCommand request, CancellationToken cancellationToken)
    {
      return await _projectTaskTypeService.DeleteProjectTaskTypeById(request.Id);
    }
  }
}
