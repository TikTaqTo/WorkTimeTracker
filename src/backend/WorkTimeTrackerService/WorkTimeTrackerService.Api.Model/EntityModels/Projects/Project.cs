using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WorkTimeTrackerService.Api.Model.EntityModels.Dictionaries;
using WorkTimeTrackerService.Api.Model.EntityModels.ProjectTasks;

namespace WorkTimeTrackerService.Api.Model.EntityModels.Projects
{
  public class Project : BaseEntity<Guid>
  {
    [Required]
    [StringLength(200)]
    public string Title { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }

    #nullable enable
    public virtual ICollection<ProjectTask>? ProjectTasks { get; set; }

    public Project()
    {
      ProjectTasks = new List<ProjectTask>();
    }
  }
}
