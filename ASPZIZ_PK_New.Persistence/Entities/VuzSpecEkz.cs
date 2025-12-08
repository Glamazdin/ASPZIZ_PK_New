using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Vuz_Spec_Ekz")]
public partial class VuzSpecEkz
{
    [Key]
    [Column("vuzSpecEkzId")]
    public int VuzSpecEkzId { get; set; }

    [Column("vuzSpecId")]
    public short VuzSpecId { get; set; }

    [Column("ekzId")]
    public byte EkzId { get; set; }

    [Column("prioritet")]
    public byte Prioritet { get; set; }

    [Column("minBall")]
    public byte? MinBall { get; set; }

    [ForeignKey("EkzId")]
    [InverseProperty("VuzSpecEkzs")]
    public virtual Exam Ekz { get; set; } = null!;
}
