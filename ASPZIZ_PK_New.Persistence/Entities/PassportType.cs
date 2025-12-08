using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("PassportType")]
public partial class PassportType
{
    [Key]
    [Column("pasTypeId")]
    public byte PasTypeId { get; set; }

    [Column("pasName")]
    [StringLength(80)]
    public string PasName { get; set; } = null!;

    [InverseProperty("PasType")]
    public virtual ICollection<Abitur> AbiturPasTypes { get; set; } = new List<Abitur>();

    [InverseProperty("PredPasType")]
    public virtual ICollection<Abitur> AbiturPredPasTypes { get; set; } = new List<Abitur>();
}
