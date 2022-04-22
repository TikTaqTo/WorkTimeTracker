using System;

namespace WorkTimeTrackerService.Domain.Requests
{
  public class AddProjectTaskStatusToProjectTaskRequest
  {
    public Guid ProjectTaskId { get; set; }
    public Guid ProjectTaskStatusId { get; set; }
  }
}
