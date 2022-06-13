using System.Collections.Generic;
using WorkTimeTrackerService.Api.Model.EntityModels.Dictionaries;

namespace WorkTimeTrackerService.Api.Model.Replies.Dictionaries
{
    public class ProjectTaskTypesReply : CommonReply
  {
    public IEnumerable<ProjectTaskType> ProjectTaskTypes { get; set; }
  }
}
