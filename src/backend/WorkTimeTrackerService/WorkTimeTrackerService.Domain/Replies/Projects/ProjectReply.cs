using WorkTimeTrackerService.Domain.EntityModels.Projects;

namespace WorkTimeTrackerService.Domain.Replies.Projects
{
  public class ProjectReply : CommonReply
  {
    public Project Project { get; set; }
  }
}
