using System;

namespace WorkTimeTrackerService.Api.Model.Requests
{
  public class AddProjectTaskStatusToProjectTaskRequest
  {
    public Guid ProjectTaskId { get; set; }
    public Guid ProjectTaskStatusId { get; set; }
  }
}
