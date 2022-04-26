using System;
using System.ComponentModel.DataAnnotations;

namespace WorkTimeTrackerService.Api.Model.EntityModels.Dictionaries
{
  public class ProjectTaskType : BaseEntity<Guid>
  {
    //Я сделал его классом так как enum не расширяем
    //Как я принял такое решение: https://habr.com/ru/post/476650/ 
    [Required]
    [StringLength(200)]
    public string Type { get; set; }
  }
}
