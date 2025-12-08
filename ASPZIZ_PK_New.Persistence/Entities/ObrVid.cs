using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Obr_Vid")]
public partial class ObrVid
{
    [Key]
    [Column("obrVidId")]
    public byte ObrVidId { get; set; }

    [Column("obrFormaId")]
    public byte ObrFormaId { get; set; }

    [Column("obrVidName")]
    [StringLength(50)]
    public string ObrVidName { get; set; } = null!;

    [Column("obrLotusCode")]
    [StringLength(10)]
    public string? ObrLotusCode { get; set; }

    [ForeignKey("ObrFormaId")]
    [InverseProperty("ObrVids")]
    public virtual ObrFroma ObrForma { get; set; } = null!;

    [InverseProperty("ObrVid")]
    public virtual ICollection<VuzSpec> VuzSpecs { get; set; } = new List<VuzSpec>();
}
