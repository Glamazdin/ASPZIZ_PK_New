using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Obr_Uchregd")]
public partial class ObrUchregd
{
    [Key]
    [Column("obrUchId")]
    public byte ObrUchId { get; set; }

    [Column("obrUrovId")]
    public byte ObrUrovId { get; set; }

    [Column("obrUchName")]
    [StringLength(100)]
    public string ObrUchName { get; set; } = null!;

    [Column("obrLotusAbbr")]
    [StringLength(32)]
    public string? ObrLotusAbbr { get; set; }

    [InverseProperty("ObrUch")]
    public virtual ICollection<Abitur> Abiturs { get; set; } = new List<Abitur>();

    [ForeignKey("ObrUrovId")]
    [InverseProperty("ObrUchregds")]
    public virtual ObrUroven ObrUrov { get; set; } = null!;
}
