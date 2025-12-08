using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Vuz_Specialization")]
public partial class VuzSpecialization
{
    [Key]
    [Column("vuzSpecializationId")]
    public short VuzSpecializationId { get; set; }

    [Column("vuzSpecId")]
    public short VuzSpecId { get; set; }

    [Column("specSpecializationId")]
    public short SpecSpecializationId { get; set; }

    [Column("countOfPlaces")]
    public short CountOfPlaces { get; set; }

    [Column("countOfPlaces_Orphan")]
    public short CountOfPlacesOrphan { get; set; }

    [Column("countOfPlaces_Guard")]
    public short CountOfPlacesGuard { get; set; }

    [Column("codeLetter")]
    [StringLength(5)]
    public string? CodeLetter { get; set; }

    [Column("bseuId")]
    public byte? BseuId { get; set; }

    [ForeignKey("SpecSpecializationId")]
    [InverseProperty("VuzSpecializations")]
    public virtual OkskSpecSpecialization SpecSpecialization { get; set; } = null!;

    [ForeignKey("VuzSpecId")]
    [InverseProperty("VuzSpecializations")]
    public virtual VuzSpec VuzSpec { get; set; } = null!;
}
