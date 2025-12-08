using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Lgoty_Polupr")]
public partial class LgotyPolupr
{
    [Key]
    [Column("ppId")]
    public byte PpId { get; set; }

    [Column("ppName_Short")]
    [StringLength(200)]
    public string PpNameShort { get; set; } = null!;

    [Column("ppName_Full")]
    [StringLength(800)]
    public string PpNameFull { get; set; } = null!;

    [Column("ppPrioritet")]
    public byte PpPrioritet { get; set; }

    [InverseProperty("Polupr")]
    public virtual ICollection<AbiturPolupr> AbiturPoluprs { get; set; } = new List<AbiturPolupr>();
}
