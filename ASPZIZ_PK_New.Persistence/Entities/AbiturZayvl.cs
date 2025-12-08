using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Abitur_Zayvl")]
public partial class AbiturZayvl
{
    [Key]
    [Column("zayvlId")]
    public int ZayvlId { get; set; }

    [Column("abiturId")]
    public Guid AbiturId { get; set; }

    [Column("vuzSpecId")]
    public short VuzSpecId { get; set; }

    [Column("prior")]
    public byte Prior { get; set; }

    [Column("applicationNumber")]
    public byte ApplicationNumber { get; set; }

    [Column("hash")]
    public int? Hash { get; set; }

    [Column("date", TypeName = "smalldatetime")]
    public DateTime? Date { get; set; }

    [ForeignKey("AbiturId")]
    [InverseProperty("AbiturZayvls")]
    public virtual Abitur Abitur { get; set; } = null!;

    [ForeignKey("VuzSpecId")]
    [InverseProperty("AbiturZayvls")]
    public virtual VuzSpec VuzSpec { get; set; } = null!;
}
