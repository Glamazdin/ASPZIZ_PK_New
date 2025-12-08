using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Abitur_Ocenki")]
public partial class AbiturOcenki
{
    [Key]
    [Column("ocId")]
    public int OcId { get; set; }

    [Column("abiturId")]
    public Guid AbiturId { get; set; }

    public byte EkzId { get; set; }

    public byte? EkzOc { get; set; }

    public byte? ObrOc { get; set; }

    [StringLength(20)]
    public string? DokNom { get; set; }

    public bool? IsSel { get; set; }

    public byte? Is100BallovId { get; set; }

    [Column("examTypeId")]
    public byte ExamTypeId { get; set; }

    [ForeignKey("AbiturId")]
    [InverseProperty("AbiturOcenkis")]
    public virtual Abitur Abitur { get; set; } = null!;

    [ForeignKey("EkzId")]
    [InverseProperty("AbiturOcenkis")]
    public virtual Exam Ekz { get; set; } = null!;

    [ForeignKey("ExamTypeId")]
    [InverseProperty("AbiturOcenkis")]
    public virtual ExamType ExamType { get; set; } = null!;
}
