using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Queries.Dictionaries.ProjectTaskTypes
{
  public class RetrieveProjectTaskTypesQueryHandler : IRequestHandler<RetrieveProjectTaskTypesQuery, ProjectTaskTypesReply>
  {
    private readonly IProjectTaskTypeService _projectTaskTypeService;

    public RetrieveProjectTaskTypesQueryHandler(IProjectTaskTypeService projectTaskTypeService)
    {
      _projectTaskTypeService = projectTaskTypeService;
    }

    public async Task<ProjectTaskTypesReply> Handle(RetrieveProjectTaskTypesQuery request, CancellationToken cancellationToken)
    {
      return await _projectTaskTypeService.RetrieveProjectTaskTypes();
    }
  }
}
