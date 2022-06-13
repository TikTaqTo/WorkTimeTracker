using System.Collections.Generic;
using WorkTimeTrackerService.Api.Model.EntityModels.Dictionaries;

namespace WorkTimeTrackerService.Api.Model.Replies.Dictionaries
{
    public class ProjectTaskStatusesReply : CommonReply
  {
    public IEnumerable<ProjectTaskStatus> ProjectTaskStatuses { get; set; }
  }
}
