using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Dictionaries;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;
using WorkTimeTrackerService.Infrastructure.Persistence;

namespace WorkTimeTrackerService.Infrastructure.Services.Dictionaries
{
  public class ProjectTaskTypeService : IProjectTaskTypeService
  {
    private readonly WorkTimeTrackerServiceContext _context;

    public ProjectTaskTypeService(WorkTimeTrackerServiceContext context)
    {
      _context = context;
    }

    public async Task<ProjectTaskTypeReply> CreateProjectTaskType(ProjectTaskType projectTaskType)
    {
      await _context.ProjectTaskTypes.AddAsync(projectTaskType);
      await _context.SaveChangesAsync();

      return new ProjectTaskTypeReply() 
      { 
        ProjectTaskType = projectTaskType 
      };
    }

    public async Task<ProjectTaskTypeReply> DeleteProjectTaskTypeById(Guid id)
    {
      var projectTaskType = await _context.ProjectTaskTypes.FindAsync(id);

      projectTaskType.DeletedAt = DateTimeOffset.UtcNow;

      //С низу возможное нарушение правила 1 правила SOLID Single-responsibility principle.
      //Мы проверяем на null хотя этим должен заниматся отдельный сервис например Validator
      //Возможно стоит сделать удаление по таймеру, не то в чём резон от того что мы меняем поля если этих записей нету в бд
      projectTaskType.DeletedBy = projectTaskType.DeletedBy == null ? "admin" : projectTaskType.DeletedBy;
      projectTaskType.DeletedReason = projectTaskType.DeletedReason == null ? "delete info" : projectTaskType.DeletedReason;

      _context.ProjectTaskTypes.Remove(projectTaskType);
      await _context.SaveChangesAsync();

      return new ProjectTaskTypeReply()
      {
        ProjectTaskType = projectTaskType
      };
    }

    public async Task<ProjectTaskTypesReply> RetrieveProjectTaskTypes()
    {
      var projectTaskTypes = _context.ProjectTaskTypes
        .AsNoTracking(); /* Не подгружаем данные в кэш клиента(WorkTimeTrackerService) это позволит экономить место и увеличить скорость */;

      var projectTaskTypesReply = new ProjectTaskTypesReply()
      {
        ProjectTaskTypes = projectTaskTypes
      };

      return await Task.FromResult(projectTaskTypesReply);
    }

    public async Task<ProjectTaskTypeReply> UpdateProjectTaskType(ProjectTaskType projectTaskType)
    {
      projectTaskType.ModifiedAt = DateTimeOffset.UtcNow;

      //С низу возможное нарушение правила 1 правила SOLID Single-responsibility principle.
      //Мы проверяем на null хотя этим должен заниматся отдельный сервис например Validator
      projectTaskType.ModifiedBy = projectTaskType.ModifiedBy == null ? "admin" : projectTaskType.ModifiedBy;
      projectTaskType.ModifiedReason = projectTaskType.ModifiedReason == null ? "update info" : projectTaskType.ModifiedReason;

      _context.ProjectTaskTypes.Update(projectTaskType);

      await _context.SaveChangesAsync();

      return new ProjectTaskTypeReply() 
      { 
        ProjectTaskType = projectTaskType
      };
    }
  }
}
