using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Vuz_Faclt")]
public partial class VuzFaclt
{
    [Key]
    [Column("facltId")]
    public short FacltId { get; set; }

    [Column("vuzId")]
    public byte VuzId { get; set; }

    [Column("facltNameRU")]
    [StringLength(255)]
    public string FacltNameRu { get; set; } = null!;

    [Column("facltAbbrRU")]
    [StringLength(50)]
    public string FacltAbbrRu { get; set; } = null!;

    [Column("facltLotusCode")]
    [StringLength(10)]
    public string? FacltLotusCode { get; set; }

    [Column("facltLotusAbbr")]
    [StringLength(32)]
    public string? FacltLotusAbbr { get; set; }

    [StringLength(32)]
    public string? ColorForStatistics { get; set; }

    [InverseProperty("Faclt")]
    public virtual ICollection<VuzSpec> VuzSpecs { get; set; } = new List<VuzSpec>();
}
