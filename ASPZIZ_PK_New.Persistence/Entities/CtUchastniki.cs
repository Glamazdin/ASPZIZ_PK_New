using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("CT_Uchastniki")]
public partial class CtUchastniki
{
    [Key]
    [Column("ctUchId")]
    public int CtUchId { get; set; }

    [Column("fam")]
    [StringLength(100)]
    public string Fam { get; set; } = null!;

    [Column("im")]
    [StringLength(100)]
    public string Im { get; set; } = null!;

    [Column("otch")]
    [StringLength(100)]
    public string? Otch { get; set; }

    [Column("pasSer")]
    [StringLength(10)]
    public string? PasSer { get; set; }

    [Column("pasNom")]
    [StringLength(20)]
    public string PasNom { get; set; } = null!;

    [InverseProperty("CtUch")]
    public virtual ICollection<CtCertificaty> CtCertificaties { get; set; } = new List<CtCertificaty>();
}
