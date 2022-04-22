using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;

namespace WorkTimeTrackerService.Infrastructure.Persistence.EntityConfiguration.Dictionaries
{
  public class ProjectTaskTypeConfiguration : EntityBaseTypeConfiguration<ProjectTaskType, Guid>
  {
    protected override void ConfigureEntity(EntityTypeBuilder<ProjectTaskType> builder)
    {
      builder.Property(x => x.Type)
        .HasMaxLength(200)
        .IsRequired();
    }
  }
}
