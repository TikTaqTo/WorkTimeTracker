using System.Collections.Generic;

namespace WorkTimeTrackerService.Domain.Replies
{
  public class CommonReply
  {
    public IEnumerable<string> Errors { get; set; }
    public IEnumerable<string> Warnings { get; set; }
  }
}
