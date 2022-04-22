using System;
using System.Threading.Tasks;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Abstractions.Dictionaries
{
  public interface IProjectTaskStatusService
  {
    Task<ProjectTaskStatusReply> CreateProjectTaskStatus(ProjectTaskStatus projectTaskStatus);

    Task<ProjectTaskStatusesReply> RetrieveProjectTaskStatuses();

    Task<ProjectTaskStatusReply> UpdateProjectTaskStatus(ProjectTaskStatus projectTaskStatus);

    Task<ProjectTaskStatusReply> DeleteProjectTaskStatusById(Guid id);
  }
}
