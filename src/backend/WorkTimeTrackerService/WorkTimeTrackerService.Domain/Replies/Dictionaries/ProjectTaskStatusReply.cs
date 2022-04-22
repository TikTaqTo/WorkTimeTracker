using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;

namespace WorkTimeTrackerService.Domain.Replies.Dictionaries
{
  public class ProjectTaskStatusReply : CommonReply
  {
    public ProjectTaskStatus ProjectTaskStatus { get; set; }
  }
}
