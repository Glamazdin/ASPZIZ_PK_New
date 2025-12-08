using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Obr_Froma")]
public partial class ObrFroma
{
    [Key]
    [Column("obrFormaId")]
    public byte ObrFormaId { get; set; }

    [Column("obrFormaName")]
    [StringLength(50)]
    public string ObrFormaName { get; set; } = null!;

    [InverseProperty("ObrForma")]
    public virtual ICollection<ObrVid> ObrVids { get; set; } = new List<ObrVid>();
}
