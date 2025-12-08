using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("SSUZ_Spec")]
public partial class SsuzSpec
{
    [Key]
    [Column("specId")]
    public short SpecId { get; set; }

    [Column("specName")]
    [StringLength(255)]
    public string SpecName { get; set; } = null!;

    [InverseProperty("SsuzSpec")]
    public virtual ICollection<VuzSsuzSpec> VuzSsuzSpecs { get; set; } = new List<VuzSsuzSpec>();
}
