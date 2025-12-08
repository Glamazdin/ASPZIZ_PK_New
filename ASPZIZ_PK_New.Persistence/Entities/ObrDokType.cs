using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Obr_DokType")]
public partial class ObrDokType
{
    [Key]
    [Column("obrDokTypeId")]
    public byte ObrDokTypeId { get; set; }

    [Column("obrUrovId")]
    public byte ObrUrovId { get; set; }

    [Column("obrDokName")]
    [StringLength(100)]
    public string ObrDokName { get; set; } = null!;

    [InverseProperty("ObrDokType")]
    public virtual ICollection<Abitur> Abiturs { get; set; } = new List<Abitur>();

    [ForeignKey("ObrUrovId")]
    [InverseProperty("ObrDokTypes")]
    public virtual ObrUroven ObrUrov { get; set; } = null!;
}
