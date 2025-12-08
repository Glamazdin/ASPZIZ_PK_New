using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Lgoti_BezEkz")]
public partial class LgotiBezEkz
{
    [Key]
    [Column("bezEkzId")]
    public byte BezEkzId { get; set; }

    [Column("beName_Short")]
    [StringLength(200)]
    public string BeNameShort { get; set; } = null!;

    [Column("beName_Full")]
    [StringLength(800)]
    public string BeNameFull { get; set; } = null!;

    [InverseProperty("BezEkz")]
    public virtual ICollection<Abitur> Abiturs { get; set; } = new List<Abitur>();
}
