using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("OKSK_Spec_Specialization")]
public partial class OkskSpecSpecialization
{
    [Key]
    public short Id { get; set; }

    [Column("specializationId")]
    public short SpecializationId { get; set; }

    [Column("specId")]
    public short SpecId { get; set; }

    [ForeignKey("SpecId")]
    [InverseProperty("OkskSpecSpecializations")]
    public virtual OkskSpec Spec { get; set; } = null!;

    [ForeignKey("SpecializationId")]
    [InverseProperty("OkskSpecSpecializations")]
    public virtual OkskSpecialization Specialization { get; set; } = null!;

    [InverseProperty("SpecSpecialization")]
    public virtual ICollection<VuzSpecialization> VuzSpecializations { get; set; } = new List<VuzSpecialization>();
}
