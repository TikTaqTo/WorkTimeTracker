using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Queries.Dictionaries.ProjectTaskStatuses
{
  public class RetrieveProjectTaskStatusesQuery : IRequest<ProjectTaskStatusesReply>
  {
  }
}
