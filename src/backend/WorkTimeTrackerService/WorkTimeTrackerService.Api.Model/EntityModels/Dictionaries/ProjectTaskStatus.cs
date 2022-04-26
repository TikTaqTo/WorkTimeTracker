using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WorkTimeTrackerService.Api.Model.EntityModels.Dictionaries
{
  public class ProjectTaskStatus : BaseEntity<Guid>
  {
    [Required]
    [StringLength(200)]
    public string Status { get; set; }
  }
}
