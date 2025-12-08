using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("ExamType")]
public partial class ExamType
{
    [Key]
    [Column("examTypeId")]
    public byte ExamTypeId { get; set; }

    [Column("examTypeName")]
    [StringLength(300)]
    public string ExamTypeName { get; set; } = null!;

    [Column("examTypeShort")]
    [StringLength(200)]
    public string? ExamTypeShort { get; set; }

    [InverseProperty("ExamType")]
    public virtual ICollection<AbiturOcenki> AbiturOcenkis { get; set; } = new List<AbiturOcenki>();

    [InverseProperty("ExamType")]
    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();
}
