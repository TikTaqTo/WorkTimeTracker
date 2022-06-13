using System.Collections.Generic;

namespace WorkTimeTrackerService.Api.Model.Replies
{
  public class CommonReply
  {
    public IEnumerable<string> Errors { get; set; }
    public IEnumerable<string> Warnings { get; set; }
  }
}
