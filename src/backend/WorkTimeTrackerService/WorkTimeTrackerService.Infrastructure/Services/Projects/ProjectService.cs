using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.Projects;
using WorkTimeTrackerService.Domain.EntityModels.Projects;
using WorkTimeTrackerService.Domain.Replies.Projects;
using WorkTimeTrackerService.Domain.Requests;
using WorkTimeTrackerService.Infrastructure.Persistence;

namespace WorkTimeTrackerService.Infrastructure.Services.Projects
{
  public class ProjectService : IProjectService
  {
    // Нету Di возможно стоит добавить
    private readonly WorkTimeTrackerServiceContext _context;

    public ProjectService(WorkTimeTrackerServiceContext context)
    {
      _context = context;
    }

    public async Task<ProjectReply> AddTaskToProject(AddProjectTaskToProjectRequest request)
    {
      var projectTask = await _context.ProjectTasks.FindAsync(request.ProjectTaskId);
      var project = await _context.Projects.FindAsync(request.ProjectId);

      //Реализовать глобальный отлов null значений для ProjectTasks и Projects или использовать код ниже : 
      /*
       if (projectTask is null) {
        throw new ArgumentNullException($"Could not find project task by id: {request.TaskId}");
      } 
      if (project is null) {
        throw new ArgumentNullException($"Could not find project by id: {request.ProjectId}");
      }
       */

      project.ProjectTasks.Add(projectTask);
      await _context.SaveChangesAsync();

      return new ProjectReply()
      {
        Project = project
      };
    }

    public async Task<ProjectReply> CreateProject(Project project)
    {
      await _context.Projects.AddAsync(project);
      await _context.SaveChangesAsync();

      return new ProjectReply()
      {
        Project = project
      };
    }

    public async Task<ProjectReply> DeleteProjectById(Guid id)
    {
      var project = await _context.Projects
        .Include(x=>x.ProjectTasks)
          .ThenInclude(x=>x.TaskStatus)
        .Include(x=>x.ProjectTasks)
          .ThenInclude(x=>x.TaskType)
        .FirstOrDefaultAsync(x=>x.Id == id);

      //С низу возможное нарушение правила 1 правила SOLID Single-responsibility principle.
      //Мы проверяем на null хотя этим должен заниматся отдельный сервис например Validator
      //Возможно стоит сделать удаление по таймеру, не то в чём резон от того что мы меняем поля если этих записей нету в бд
      project.DeletedAt = DateTimeOffset.UtcNow;
      project.DeletedBy = project.DeletedBy == null ? "admin" : project.DeletedBy;
      project.DeletedReason = project.DeletedReason == null ? "detele info" : project.DeletedReason;


      _context.Projects.Remove(project);
      await _context.SaveChangesAsync();

      return new ProjectReply()
      {
        Project = project
      };
    }

    public async Task<ProjectReply> RetrieveProjectById(Guid id)
    {
      /*
      .Include(x => x.ProjectTasks)
          .ThenInclude( x => x.TaskStatus)
      .Include( x => x.ProjectTasks)
          .ThenInclude( x=> x.TaskType)
      Временное решение так как я ещё не нашёл как не спускатся на уровень ниже без повторения ThenInclude
      Информация: https://entityframework-classic.net/then-include
       */
      var project = _context.Projects
        .Include(x => x.ProjectTasks)
          .ThenInclude( x => x.TaskStatus)
        .Include( x => x.ProjectTasks)
          .ThenInclude( x => x.TaskType)
        .AsQueryable() /* Выборка из бд только нужных данных где ProjectId == id */
        .AsSplitQuery() /* Мы говорим что нужно сделать 6 запроса в бд вместо 1 большого с 6 JOIN */
        .AsNoTracking() /* Не подгружаем данные в кэш клиента(WorkTimeTrackerService) это позволит экономить место кэша и увеличить скорость */
        .FirstOrDefaultAsync(x => x.Id == id); /* Мы сразу обращаемся к бд с запросом, и не проверяем данные в контексте, если нужен контекст лучше использовать findAsync */

      var projectReply = new ProjectReply()
      {
        Project = await project
      };

      return await Task.FromResult(projectReply);
    }

    // Этот метод только для тестирования, лучше его на проде не использовать, подгружать все данные из таблицы в бд не самая хорошая идея
    public async Task<ProjectsReply> RetrieveProjects()
    {
      var projects = _context.Projects
        .AsNoTracking(); /* Не подгружаем данные в кэш клиента(WorkTimeTrackerService) это позволит экономить место кэша и увеличить скорость */

      var projectsReply = new ProjectsReply
      {
        Projects = projects
      };

      return await Task.FromResult(projectsReply);
    }

    public async Task<ProjectReply> UpdateProject(Project project)
    {
      //Проверить умеет ли он обновлять связанные данные из таблиц ProjectTasks 
      _context.Projects.Update(project);
      await _context.SaveChangesAsync();
      return new ProjectReply()
      {
        Project = project
      };
    }
  }
}
