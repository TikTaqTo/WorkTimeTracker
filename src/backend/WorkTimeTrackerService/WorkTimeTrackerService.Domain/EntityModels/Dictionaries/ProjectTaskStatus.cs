using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WorkTimeTrackerService.Domain.EntityModels.ProjectTasks;

namespace WorkTimeTrackerService.Domain.EntityModels.Dictionaries
{
  public class ProjectTaskStatus : BaseEntity<Guid>
  {
    [Required]
    [StringLength(200)]
    public string Status { get; set; }

    #nullable enable
    public virtual ICollection<ProjectTask>? ProjectTasks { get; set; }

    public ProjectTaskStatus()
    {
      ProjectTasks = new List<ProjectTask>();
    }
  }
}
