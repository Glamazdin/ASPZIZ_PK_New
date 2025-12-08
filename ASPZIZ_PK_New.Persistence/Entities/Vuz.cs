using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Vuz")]
public partial class Vuz
{
    [Key]
    [Column("vuzId")]
    public byte VuzId { get; set; }

    [Column("vuzNameRU")]
    [StringLength(100)]
    public string VuzNameRu { get; set; } = null!;

    [Column("vuzAbbrRU")]
    [StringLength(10)]
    public string? VuzAbbrRu { get; set; }

    [Column("vuzNameBY")]
    [StringLength(100)]
    public string? VuzNameBy { get; set; }

    [Column("vuAbbrBY")]
    [StringLength(50)]
    public string? VuAbbrBy { get; set; }

    [InverseProperty("Vuz")]
    public virtual ICollection<VuzSpec> VuzSpecs { get; set; } = new List<VuzSpec>();
}
