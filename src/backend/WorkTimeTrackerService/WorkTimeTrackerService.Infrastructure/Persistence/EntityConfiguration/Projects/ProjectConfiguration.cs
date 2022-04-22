using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WorkTimeTrackerService.Domain.EntityModels.Projects;

namespace WorkTimeTrackerService.Infrastructure.Persistence.EntityConfiguration.Projects
{
  public class ProjectConfiguration : EntityBaseTypeConfiguration<Project, Guid>
  {
    protected override void ConfigureEntity(EntityTypeBuilder<Project> builder)
    {
      builder.Property(x => x.Title)
        .HasMaxLength(200)
        .IsRequired();

      builder.Property(x => x.Description)
        .HasMaxLength(1000);

      builder.HasMany(x => x.ProjectTasks)
        .WithOne(x => x.Project)
        .OnDelete(DeleteBehavior.Cascade);
    }
  }
}
