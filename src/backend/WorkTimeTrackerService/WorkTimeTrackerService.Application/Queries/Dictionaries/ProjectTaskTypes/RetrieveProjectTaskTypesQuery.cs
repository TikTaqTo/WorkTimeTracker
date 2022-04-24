using MediatR;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Queries.Dictionaries.ProjectTaskTypes.ProjectTaskTypes
{
  public class RetrieveProjectTaskTypesQuery : IRequest<ProjectTaskTypesReply>
  {
  }
}
