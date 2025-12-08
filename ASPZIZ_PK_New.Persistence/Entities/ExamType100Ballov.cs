using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("ExamType_100_ballov")]
public partial class ExamType100Ballov
{
    [Key]
    [Column("id")]
    public byte Id { get; set; }

    [Column("ekzId")]
    public byte EkzId { get; set; }

    [StringLength(255)]
    public string? Opisanie { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    [ForeignKey("EkzId")]
    [InverseProperty("ExamType100Ballovs")]
    public virtual Exam Ekz { get; set; } = null!;
}
