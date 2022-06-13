using System.Collections.Generic;
using WorkTimeTrackerService.Api.Model.EntityModels.ProjectTasks;

namespace WorkTimeTrackerService.Api.Model.Replies.ProjectTasks
{
    public class ProjectTasksReply : CommonReply
  {
    public IEnumerable<ProjectTask> Tasks { get; set; } 
  }
}
