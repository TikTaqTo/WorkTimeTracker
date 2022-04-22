using WorkTimeTrackerService.Domain.EntityModels.ProjectTasks;

namespace WorkTimeTrackerService.Domain.Replies.ProjectTasks
{
  public class ProjectTaskReply : CommonReply
  {
    public ProjectTask Task { get; set; }
  }
}
