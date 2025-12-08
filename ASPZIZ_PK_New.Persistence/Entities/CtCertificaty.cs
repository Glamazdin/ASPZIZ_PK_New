using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("CT_Certificaty")]
public partial class CtCertificaty
{
    [Key]
    [Column("ctId")]
    public int CtId { get; set; }

    [Column("ctUchId")]
    public int CtUchId { get; set; }

    [Column("predmId")]
    public byte PredmId { get; set; }

    [Column("ball")]
    public byte Ball { get; set; }

    [Column("ctNomer")]
    [StringLength(30)]
    public string CtNomer { get; set; } = null!;

    [ForeignKey("CtUchId")]
    [InverseProperty("CtCertificaties")]
    public virtual CtUchastniki CtUch { get; set; } = null!;

    [ForeignKey("PredmId")]
    [InverseProperty("CtCertificaties")]
    public virtual Exam Predm { get; set; } = null!;
}
