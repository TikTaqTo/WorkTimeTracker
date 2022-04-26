using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimeTrackerService.Api.Model.EntityModels.Dictionaries
{
  public class BaseEntity<TKey>
        where TKey : struct
  {

    /// <summary>
    ///     Primary key (Generic)
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public TKey Id { get; set; }
  }
}
