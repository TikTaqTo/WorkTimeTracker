using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;
using WorkTimeTrackerService.Domain.EntityModels.Projects;

namespace WorkTimeTrackerService.Domain.EntityModels.ProjectTasks
{
  public class ProjectTask : BaseEntity<Guid>
  {
    [Required]
    [StringLength(200)]
    public string Title { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }

    public string Comment { get; set; }

    public bool IsComplete { get; set; }

    public DateTimeOffset taskStartAt { get; set; }
    
    public DateTimeOffset taskEndAt { get; set; }

    [Required]
    public Guid ProjectId { get; set; }

    [Required]
    [ForeignKey(nameof(ProjectId))]
    #nullable disable
    public virtual Project Project { get; set; }

    public Guid? TaskTypeId { get; set; }

    [ForeignKey(nameof(TaskTypeId))]
    #nullable enable
    public virtual ProjectTaskType? TaskType { get; set; }

    public Guid? TaskStatusId { get; set; }

    [ForeignKey(nameof(TaskStatusId))]
    #nullable enable
    public virtual ProjectTaskStatus? TaskStatus { get; set; }
  }
}
