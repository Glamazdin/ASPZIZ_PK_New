using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Obr_Uroven")]
public partial class ObrUroven
{
    [Key]
    [Column("obrUrovId")]
    public byte ObrUrovId { get; set; }

    [Column("obrUrovName")]
    [StringLength(50)]
    public string ObrUrovName { get; set; } = null!;

    [InverseProperty("ObrUrov")]
    public virtual ICollection<Abitur> Abiturs { get; set; } = new List<Abitur>();

    [InverseProperty("ObrUrov")]
    public virtual ICollection<ObrDokType> ObrDokTypes { get; set; } = new List<ObrDokType>();

    [InverseProperty("ObrUrov")]
    public virtual ICollection<ObrUchregd> ObrUchregds { get; set; } = new List<ObrUchregd>();
}
