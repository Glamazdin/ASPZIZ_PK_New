using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Vuz_SSUZ_Spec")]
public partial class VuzSsuzSpec
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("vuzSpecId")]
    public short VuzSpecId { get; set; }

    [Column("ssuzSpecId")]
    public short SsuzSpecId { get; set; }

    [ForeignKey("SsuzSpecId")]
    [InverseProperty("VuzSsuzSpecs")]
    public virtual SsuzSpec SsuzSpec { get; set; } = null!;
}
