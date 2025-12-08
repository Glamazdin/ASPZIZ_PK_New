using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("OKSK_Spec")]
public partial class OkskSpec
{
    [Key]
    [Column("specId")]
    public short SpecId { get; set; }

    [Column("specName")]
    [StringLength(255)]
    public string SpecName { get; set; } = null!;

    [Column("specCode")]
    [StringLength(20)]
    public string? SpecCode { get; set; }

    [Column("specKvalif")]
    [StringLength(200)]
    public string? SpecKvalif { get; set; }

    [Column("specAbbr")]
    [StringLength(50)]
    public string? SpecAbbr { get; set; }

    [Column("specLotusCode")]
    [StringLength(10)]
    public string? SpecLotusCode { get; set; }

    [InverseProperty("Spec")]
    public virtual ICollection<OkskSpecSpecialization> OkskSpecSpecializations { get; set; } = new List<OkskSpecSpecialization>();

    [InverseProperty("Spec")]
    public virtual ICollection<VuzSpec> VuzSpecs { get; set; } = new List<VuzSpec>();
}
