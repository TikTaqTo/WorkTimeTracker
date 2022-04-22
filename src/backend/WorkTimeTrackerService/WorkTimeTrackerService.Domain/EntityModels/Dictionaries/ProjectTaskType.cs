using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WorkTimeTrackerService.Domain.EntityModels.ProjectTasks;

namespace WorkTimeTrackerService.Domain.EntityModels.Dictionaries
{
  public class ProjectTaskType : BaseEntity<Guid>
  {

    //Я сделал его классом так как enum не расширяем
    //Как я принял такое решение: https://habr.com/ru/post/476650/ 
    [Required]
    [StringLength(200)]
    public string Type { get; set; }

    #nullable enable
    public virtual ICollection<ProjectTask>? ProjectTasks { get; set; }

    public ProjectTaskType()
    {
      ProjectTasks = new List<ProjectTask>();
    }

    ///// <summary>
    ///// Задача
    ///// </summary>
    //Task = 1,
    ///// <summary>
    ///// Ошибка
    ///// </summary>
    //Fault = 2,
    ///// <summary>
    ///// Новая функция
    ///// </summary>
    //NewFeature = 3,
    ///// <summary>
    ///// Улучшение
    ///// </summary>
    //Improvement = 4,
    ///// <summary>
    ///// Epic
    ///// </summary>
    //Epic = 5,
    ///// <summary>
    ///// История
    ///// </summary>
    //History = 6,
    ///// <summary>
    ///// Обращение на СП
    ///// </summary>
    //AppealjointVenture = 7
  }
}
