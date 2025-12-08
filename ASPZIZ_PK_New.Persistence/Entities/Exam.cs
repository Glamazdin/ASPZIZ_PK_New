using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Exam")]
public partial class Exam
{
    [Key]
    [Column("ekzId")]
    public byte EkzId { get; set; }

    [Column("ekzName")]
    [StringLength(255)]
    public string EkzName { get; set; } = null!;

    [Column("ekzGroupId")]
    public byte? EkzGroupId { get; set; }

    [Column("examTypeId")]
    public byte ExamTypeId { get; set; }

    [InverseProperty("Ekz")]
    public virtual ICollection<AbiturOcenki> AbiturOcenkis { get; set; } = new List<AbiturOcenki>();

    [InverseProperty("Predm")]
    public virtual ICollection<CtCertificaty> CtCertificaties { get; set; } = new List<CtCertificaty>();

    [ForeignKey("ExamTypeId")]
    [InverseProperty("Exams")]
    public virtual ExamType ExamType { get; set; } = null!;

    [InverseProperty("Ekz")]
    public virtual ICollection<ExamType100Ballov> ExamType100Ballovs { get; set; } = new List<ExamType100Ballov>();

    [InverseProperty("Ekz")]
    public virtual ICollection<VuzSpecEkz> VuzSpecEkzs { get; set; } = new List<VuzSpecEkz>();
}
