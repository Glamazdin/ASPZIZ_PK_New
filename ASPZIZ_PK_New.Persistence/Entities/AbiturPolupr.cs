using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Abitur_Polupr")]
public partial class AbiturPolupr
{
    [Key]
    [Column("abtPoluprId")]
    public int AbtPoluprId { get; set; }

    [Column("abiturId")]
    public Guid AbiturId { get; set; }

    [Column("poluprId")]
    public byte PoluprId { get; set; }

    [ForeignKey("AbiturId")]
    [InverseProperty("AbiturPoluprs")]
    public virtual Abitur Abitur { get; set; } = null!;

    [ForeignKey("PoluprId")]
    [InverseProperty("AbiturPoluprs")]
    public virtual LgotyPolupr Polupr { get; set; } = null!;
}
