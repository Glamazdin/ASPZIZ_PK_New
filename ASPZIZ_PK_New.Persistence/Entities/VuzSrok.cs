using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Vuz_Srok")]
public partial class VuzSrok
{
    [Key]
    [Column("vuzSrokId")]
    public byte VuzSrokId { get; set; }

    [Column("srokName")]
    [StringLength(50)]
    public string SrokName { get; set; } = null!;

    [InverseProperty("VuzSrok")]
    public virtual ICollection<VuzSpec> VuzSpecs { get; set; } = new List<VuzSpec>();
}
