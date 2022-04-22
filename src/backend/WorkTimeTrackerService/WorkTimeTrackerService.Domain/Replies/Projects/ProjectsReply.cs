using System.Collections.Generic;
using WorkTimeTrackerService.Domain.EntityModels.Projects;

namespace WorkTimeTrackerService.Domain.Replies.Projects
{
  public class ProjectsReply : CommonReply
  {
    public IEnumerable<Project> Projects { get; set; }
  }
}
