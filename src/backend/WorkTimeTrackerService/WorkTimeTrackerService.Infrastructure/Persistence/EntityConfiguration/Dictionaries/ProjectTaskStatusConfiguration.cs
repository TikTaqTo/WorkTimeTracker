using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;

namespace WorkTimeTrackerService.Infrastructure.Persistence.EntityConfiguration.Dictionaries
{
  public class ProjectTaskStatusConfiguration : EntityBaseTypeConfiguration<ProjectTaskStatus, Guid>
  {
    protected override void ConfigureEntity(EntityTypeBuilder<ProjectTaskStatus> builder)
    {
      builder.Property(x => x.Status)
        .HasMaxLength(200)
        .IsRequired();
    }
  }
}
