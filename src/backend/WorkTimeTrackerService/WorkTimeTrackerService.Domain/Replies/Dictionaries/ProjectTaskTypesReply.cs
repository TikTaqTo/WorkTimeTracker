using System.Collections.Generic;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;

namespace WorkTimeTrackerService.Domain.Replies.Dictionaries
{
  public class ProjectTaskTypesReply : CommonReply
  {
    public IEnumerable<ProjectTaskType> ProjectTaskTypes { get; set; }
  }
}
