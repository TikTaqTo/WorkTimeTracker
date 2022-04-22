using System;
using System.Threading.Tasks;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Abstractions.Dictionaries
{
  public interface IProjectTaskTypeService
  {
    Task<ProjectTaskTypeReply> CreateProjectTaskType(ProjectTaskType projectTaskType);

    Task<ProjectTaskTypesReply> RetrieveProjectTaskTypes();

    Task<ProjectTaskTypeReply> UpdateProjectTaskType(ProjectTaskType projectTaskType);

    Task<ProjectTaskTypeReply> DeleteProjectTaskTypeById(Guid id);
  }
}
