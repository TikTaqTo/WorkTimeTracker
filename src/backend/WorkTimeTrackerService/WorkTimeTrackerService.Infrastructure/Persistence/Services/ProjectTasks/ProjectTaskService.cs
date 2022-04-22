using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.ProjectTasks;
using WorkTimeTrackerService.Domain.EntityModels.ProjectTasks;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;
using WorkTimeTrackerService.Domain.Requests;
using WorkTimeTrackerService.Infrastructure.Persistence;

namespace WorkTimeTrackerService.Infrastructure.Services.ProjectTasks
{
  public class ProjectTaskService : IProjectTaskService
  {
    private readonly WorkTimeTrackerServiceContext _context;

    public ProjectTaskService(WorkTimeTrackerServiceContext context)
    {
      _context = context;
    }

    public async Task<ProjectTaskReply> AddProjectTaskTypeToProjectTask(AddProjectTaskTypeToProjectTaskRequest request)
    {
      var projectTask = await _context.ProjectTasks.FindAsync(request.ProjectTaskId);
      var projectTaskType = await _context.ProjectTaskTypes.FindAsync(request.ProjectTaskTypeId);

      //Реализовать глобальный отлов null значений для projectTaskType или projectTask или использовать код ниже : 
      /*
       if (projectTask is null) {
        throw new ArgumentNullException($"Could not find project task by id: {request.ProjectTaskId}");
      } 
      if (projectTaskType is null) {
        throw new ArgumentNullException($"Could not find project task type by id: {request.ProjectTaskTypeId}");
      }
       */

      projectTaskType.ProjectTasks.Add(projectTask);
      await _context.SaveChangesAsync();

      return new ProjectTaskReply()
      {
        Task = projectTask
      };
    }

    public async Task<ProjectTaskReply> AddProjectTaskStatusToProjectTask(AddProjectTaskStatusToProjectTaskRequest request) 
    {
      var projectTask = await _context.ProjectTasks.FindAsync(request.ProjectTaskId);
      var projectTaskStatus = await _context.ProjectTaskStatuses.FindAsync(request.ProjectTaskStatusId);

      //Реализовать глобальный отлов null значений для projectTaskType или projectTask или использовать код ниже : 
      /*
       if (projectTask is null) {
        throw new ArgumentNullException($"Could not find project task by id: {request.ProjectTaskId}");
      } 
      if (projectTaskStatus is null) {
        throw new ArgumentNullException($"Could not find project task status by id: {request.projectTaskStatusId}");
      }
       */

      projectTaskStatus.ProjectTasks.Add(projectTask);
      await _context.SaveChangesAsync();

      return new ProjectTaskReply()
      {
        Task = projectTask
      };
    }

    public async Task<ProjectTaskReply> CreateProjectTask(ProjectTask projectTask)
    {
      await _context.ProjectTasks.AddAsync(projectTask);
      await _context.SaveChangesAsync();

      return new ProjectTaskReply()
      {
        Task = projectTask
      };
    }

    public async Task<ProjectTaskReply> DeleteProjectTaskById(Guid id)
    {
      var projectTask = await _context.ProjectTasks.FindAsync(id);
     
      _context.ProjectTasks.Remove(projectTask);

      await _context.SaveChangesAsync();

      return new ProjectTaskReply()
      {
        Task = projectTask
      };
    }

    public async Task<ProjectTaskReply> RetrieveProjectTaskById(Guid id)
    {
      var projectTask = _context.ProjectTasks
        .Include(x => x.TaskStatus)
        .Include(x => x.TaskType)
        .AsQueryable() /* Выборка из бд только нужных данных где ProjectTaskId == id */
        .AsSplitQuery() /* Мы говорим что нужно сделать 6 запроса в бд вместо 1 большого с 2 JOIN */
        .AsNoTracking() /* Не подгружаем данные в кэш клиента(WorkTimeTrackerService) это позволит экономить место кэша и увеличить скорость */
        .FirstOrDefaultAsync(x => x.Id == id);

      return new ProjectTaskReply()
      {
        Task = await projectTask
      };
    }

    public async Task<ProjectTasksReply> RetrieveProjectTasks()
    {
      var projectTasks = _context.ProjectTasks
        .AsNoTracking();

      var projectTasksReply = new ProjectTasksReply
      {
        Tasks = projectTasks
      };

      return await Task.FromResult(projectTasksReply);
    }

    public async Task<ProjectTasksReply> RetrieveProjectTasksByProjectId(Guid id)
    {
      var projectTasks = _context.ProjectTasks
        .Include(x => x.TaskStatus)
        .Include(x => x.TaskType)
        .Where(x => x.ProjectId == id)
        .AsQueryable() /* Выборка из бд только нужных данных где ProjectId == id */
        .AsSplitQuery() /* Мы говорим что нужно сделать 4 запроса в бд вместо 1 большого с кучей JOIN */
        .AsNoTracking(); /* Не подгружаем данные в кэш клиента(WorkTimeTrackerService) это позволит экономить место кэша и увеличить скорость */;

      var projectTasksReply = new ProjectTasksReply()
      {
        Tasks = projectTasks
      };

      return await Task.FromResult(projectTasksReply);
    }

    public async Task<ProjectTaskReply> UpdateProjectTask(ProjectTask projectTask)
    {
      projectTask.ModifiedAt = DateTimeOffset.UtcNow;

      //С низу возможное нарушение правила 1 правила SOLID Single-responsibility principle.
      //Мы проверяем на null хотя этим должен заниматся отдельный сервис например Validator
      projectTask.ModifiedBy = projectTask.ModifiedBy == null ? "admin" : projectTask.ModifiedBy;
      projectTask.ModifiedReason = projectTask.ModifiedReason == null ? "update info" : projectTask.ModifiedReason;

      _context.Update(projectTask);
      await _context.SaveChangesAsync();

      return new ProjectTaskReply()
      {
        Task = projectTask
      };
    }
  }
}
