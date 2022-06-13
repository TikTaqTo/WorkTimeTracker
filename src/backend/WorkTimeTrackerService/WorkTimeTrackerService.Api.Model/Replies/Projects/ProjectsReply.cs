using System.Collections.Generic;
using WorkTimeTrackerService.Api.Model.EntityModels.Projects;

namespace WorkTimeTrackerService.Api.Model.Replies.Projects
{
    public class ProjectsReply : CommonReply
  {
    public IEnumerable<Project> Projects { get; set; }
  }
}
