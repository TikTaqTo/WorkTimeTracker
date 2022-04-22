using System.Collections.Generic;
using WorkTimeTrackerService.Domain.EntityModels.ProjectTasks;

namespace WorkTimeTrackerService.Domain.Replies.ProjectTasks
{
  public class ProjectTasksReply : CommonReply
  {
    public IEnumerable<ProjectTask> Tasks { get; set; } 
  }
}
