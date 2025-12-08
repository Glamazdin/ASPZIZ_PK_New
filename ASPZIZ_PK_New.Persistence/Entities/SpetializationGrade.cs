using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Spetialization_grade")]
public partial class SpetializationGrade
{
    [Key]
    public byte ProfileClassId { get; set; }

    [StringLength(80)]
    public string ProfileClassName { get; set; } = null!;

    [InverseProperty("SpetializationClass")]
    public virtual ICollection<Abitur> Abiturs { get; set; } = new List<Abitur>();
}
