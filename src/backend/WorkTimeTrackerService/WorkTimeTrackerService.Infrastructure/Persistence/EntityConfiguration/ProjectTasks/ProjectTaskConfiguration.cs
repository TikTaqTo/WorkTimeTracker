using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WorkTimeTrackerService.Domain.EntityModels.ProjectTasks;

namespace WorkTimeTrackerService.Infrastructure.Persistence.EntityConfiguration.Dictionaries
{
  public class ProjectTaskConfiguration : EntityBaseTypeConfiguration<ProjectTask, Guid>
  {
    protected override void ConfigureEntity(EntityTypeBuilder<ProjectTask> builder)
    {
      builder.Property(x => x.Title)
        .HasMaxLength(200)
        .IsRequired();

      builder.Property(x => x.Description)
        .HasMaxLength(1000);

      builder.HasOne(x => x.TaskStatus)
        .WithMany(x => x.ProjectTasks);

      builder.HasOne(x => x.TaskType)
        .WithMany(x => x.ProjectTasks);
    }
  }
}
