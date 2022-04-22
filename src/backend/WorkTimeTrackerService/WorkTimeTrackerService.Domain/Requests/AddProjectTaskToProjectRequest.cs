using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimeTrackerService.Domain.Requests
{
  public class AddProjectTaskToProjectRequest
  {
    public Guid ProjectTaskId { get; set; }

    public Guid ProjectId { get; set; }
  }
}
