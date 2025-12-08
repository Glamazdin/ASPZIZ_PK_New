using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("OKSK_Specialization")]
public partial class OkskSpecialization
{
    [Key]
    [Column("specializationId")]
    public short SpecializationId { get; set; }

    [Column("specializationName")]
    [StringLength(255)]
    public string SpecializationName { get; set; } = null!;

    [Column("specializationAbbr")]
    [StringLength(50)]
    public string? SpecializationAbbr { get; set; }

    [Column("specializationCode")]
    [StringLength(50)]
    public string? SpecializationCode { get; set; }

    [Column("specializationLetter")]
    [StringLength(5)]
    public string? SpecializationLetter { get; set; }

    [InverseProperty("Specialization")]
    public virtual ICollection<OkskSpecSpecialization> OkskSpecSpecializations { get; set; } = new List<OkskSpecSpecialization>();
}
