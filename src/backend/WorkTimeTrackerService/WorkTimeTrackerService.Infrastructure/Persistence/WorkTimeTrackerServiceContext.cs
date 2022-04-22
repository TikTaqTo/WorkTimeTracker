using Microsoft.EntityFrameworkCore;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;
using WorkTimeTrackerService.Domain.EntityModels.Projects;
using WorkTimeTrackerService.Domain.EntityModels.ProjectTasks;

namespace WorkTimeTrackerService.Infrastructure.Persistence
{
  public class WorkTimeTrackerServiceContext : DbContext
  {
    public WorkTimeTrackerServiceContext(DbContextOptions options) : base(options)
    {
    }

    public WorkTimeTrackerServiceContext()
    {
    }

    #region Dictionaries
    public virtual DbSet<ProjectTask> ProjectTasks { get; set; }

    public virtual DbSet<ProjectTaskType> ProjectTaskTypes { get; set; }

    public virtual DbSet<ProjectTaskStatus> ProjectTaskStatuses { get; set; }
    #endregion

    #region Projects
    public virtual DbSet<Project> Projects { get; set; }
    #endregion

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      if (!options.IsConfigured)
      {
        options.UseSqlServer("Data Source=DESKTOP-K2327PS;Initial Catalog=WorkTimeTracker.TimeTrackerService;Integrated Security=True");
      }
      base.OnConfiguring(options);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
    }
  }
}
