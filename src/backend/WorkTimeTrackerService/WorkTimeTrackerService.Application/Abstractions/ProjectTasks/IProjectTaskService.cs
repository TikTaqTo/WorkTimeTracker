using System;
using System.Threading.Tasks;
using WorkTimeTrackerService.Domain.EntityModels.ProjectTasks;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;
using WorkTimeTrackerService.Domain.Requests;

namespace WorkTimeTrackerService.Application.Abstractions.ProjectTasks
{
  public interface IProjectTaskService
  {
    Task<ProjectTaskReply> CreateProjectTask(ProjectTask projectTask);

    Task<ProjectTasksReply> RetrieveProjectTasks();

    Task<ProjectTaskReply> UpdateProjectTask(ProjectTask projectTask);

    Task<ProjectTaskReply> DeleteProjectTaskById(Guid id);

    Task<ProjectTaskReply> RetrieveProjectTaskById(Guid id);

    Task<ProjectTasksReply> RetrieveProjectTasksByProjectId(Guid id);

    Task<ProjectTaskReply> AddProjectTaskStatusToProjectTask(AddProjectTaskStatusToProjectTaskRequest request);

    Task<ProjectTaskReply> AddProjectTaskTypeToProjectTask(AddProjectTaskTypeToProjectTaskRequest request);
  }
}
