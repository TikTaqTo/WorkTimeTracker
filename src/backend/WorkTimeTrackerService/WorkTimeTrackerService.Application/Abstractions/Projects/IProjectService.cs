using System;
using System.Threading.Tasks;
using WorkTimeTrackerService.Domain.EntityModels.Projects;
using WorkTimeTrackerService.Domain.Replies.Projects;
using WorkTimeTrackerService.Domain.Requests;

namespace WorkTimeTrackerService.Application.Abstractions.Projects
{
  public interface IProjectService
  {
    Task<ProjectReply> CreateProject(Project project);

    Task<ProjectsReply> RetrieveProjects();

    Task<ProjectReply> UpdateProject(Project project);

    Task<ProjectReply> DeleteProjectById(Guid id);

    Task<ProjectReply> RetrieveProjectById(Guid id);

    Task<ProjectReply> AddTaskToProject(AddProjectTaskToProjectRequest request);
  }
}
