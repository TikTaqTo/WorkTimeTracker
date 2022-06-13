using WorkTimeTrackerService.Api.Model.EntityModels.ProjectTasks;

namespace WorkTimeTrackerService.Api.Model.Replies.ProjectTasks
{
    public class ProjectTaskReply : CommonReply
  {
    public ProjectTask Task { get; set; }
  }
}
