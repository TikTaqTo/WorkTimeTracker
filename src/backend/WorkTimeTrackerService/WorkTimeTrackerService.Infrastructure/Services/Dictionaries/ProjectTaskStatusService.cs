using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Dictionaries;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;
using WorkTimeTrackerService.Infrastructure.Persistence;

namespace WorkTimeTrackerService.Infrastructure.Services.Dictionaries
{
  public class ProjectTaskStatusService : IProjectTaskStatusService
  {
    private readonly WorkTimeTrackerServiceContext _context;

    public ProjectTaskStatusService(WorkTimeTrackerServiceContext context)
    {
      _context = context;
    }

    public async Task<ProjectTaskStatusReply> CreateProjectTaskStatus(ProjectTaskStatus projectTaskStatus)
    {
      await _context.ProjectTaskStatuses.AddAsync(projectTaskStatus);
      await _context.SaveChangesAsync();

      return new ProjectTaskStatusReply()
      {
        ProjectTaskStatus = projectTaskStatus
      };
    }

    public async Task<ProjectTaskStatusReply> DeleteProjectTaskStatusById(Guid id)
    {
      var projectTaskStatus = await _context.ProjectTaskStatuses.FindAsync(id);

      projectTaskStatus.DeletedAt = DateTimeOffset.UtcNow;

      //С низу возможное нарушение правила 1 правила SOLID Single-responsibility principle.
      //Мы проверяем на null хотя этим должен заниматся отдельный сервис например Validator
      //Возможно стоит сделать удаление по таймеру, не то в чём резон от того что мы меняем поля если этих записей нету в бд
      projectTaskStatus.DeletedBy = projectTaskStatus.DeletedBy == null ? "admin" : projectTaskStatus.DeletedBy;
      projectTaskStatus.DeletedReason = projectTaskStatus.DeletedReason == null ? "delete info" : projectTaskStatus.DeletedReason;

      _context.Remove(projectTaskStatus);
      await _context.SaveChangesAsync();

      return new ProjectTaskStatusReply()
      {
        ProjectTaskStatus = projectTaskStatus
      };
    }

    public async Task<ProjectTaskStatusesReply> RetrieveProjectTaskStatuses()
    {
      var projectTaskStatuses = _context.ProjectTaskStatuses
        .AsNoTracking(); /* Не подгружаем данные в кэш клиента(WorkTimeTrackerService) это позволит экономить место в кэше и увеличить скорость */;

      var projectTaskStatusesReply = new ProjectTaskStatusesReply()
      {
        ProjectTaskStatuses = projectTaskStatuses
      };

      return await Task.FromResult(projectTaskStatusesReply);
    }

    public async Task<ProjectTaskStatusReply> UpdateProjectTaskStatus(ProjectTaskStatus projectTaskStatus)
    {
      projectTaskStatus.ModifiedAt = DateTimeOffset.UtcNow;

      //С низу возможное нарушение правила 1 правила SOLID Single-responsibility principle.
      //Мы проверяем на null хотя этим должен заниматся отдельный сервис например Validator
      projectTaskStatus.ModifiedBy = projectTaskStatus.ModifiedBy == null ? "admin" : projectTaskStatus.ModifiedBy;
      projectTaskStatus.ModifiedReason = projectTaskStatus.ModifiedReason == null ? "update info" : projectTaskStatus.ModifiedReason;

      _context.ProjectTaskStatuses.Update(projectTaskStatus);
      
      await _context.SaveChangesAsync();
      
      return new ProjectTaskStatusReply()
      {
        ProjectTaskStatus = projectTaskStatus
      };
    }
  }
}
