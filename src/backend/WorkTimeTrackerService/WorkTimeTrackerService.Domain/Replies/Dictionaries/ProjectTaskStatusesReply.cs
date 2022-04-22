using System.Collections.Generic;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;

namespace WorkTimeTrackerService.Domain.Replies.Dictionaries
{
  public class ProjectTaskStatusesReply : CommonReply
  {
    public IEnumerable<ProjectTaskStatus> ProjectTaskStatuses { get; set; }
  }
}
