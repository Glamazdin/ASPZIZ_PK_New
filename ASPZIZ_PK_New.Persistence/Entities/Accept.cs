using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Accept")]
public partial class Accept
{
    [Key]
    [Column("recordId")]
    public int RecordId { get; set; }

    [Column("isPreview")]
    public bool IsPreview { get; set; }

    [Column("abiturId")]
    public Guid AbiturId { get; set; }

    [Column("groupId")]
    public byte GroupId { get; set; }

    [Column("acceptInGroup_StepId")]
    public byte? AcceptInGroupStepId { get; set; }

    [Column("acceptInGroup_UserId")]
    public Guid? AcceptInGroupUserId { get; set; }

    [Column("acceptInGroup_DateTime", TypeName = "datetime")]
    public DateTime? AcceptInGroupDateTime { get; set; }

    [Column("acceptInGroup_Position")]
    public int? AcceptInGroupPosition { get; set; }

    [Column("acceptInGroup_Result")]
    public bool? AcceptInGroupResult { get; set; }

    [Column("acceptInSpeciality_StepId")]
    public byte? AcceptInSpecialityStepId { get; set; }

    [Column("acceptInSpeciality_UserId")]
    public Guid? AcceptInSpecialityUserId { get; set; }

    [Column("acceptInSpeciality_DateTime", TypeName = "datetime")]
    public DateTime? AcceptInSpecialityDateTime { get; set; }

    [Column("acceptInSpeciality_Position")]
    public int? AcceptInSpecialityPosition { get; set; }

    [Column("acceptInSpeciality_SpecialityId")]
    public short AcceptInSpecialitySpecialityId { get; set; }

    [Column("acceptInSpeciality_Result")]
    public bool? AcceptInSpecialityResult { get; set; }

    [Column("acceptInSpecialization_UserId")]
    public Guid? AcceptInSpecializationUserId { get; set; }

    [Column("acceptInSpecialization_DateTime", TypeName = "datetime")]
    public DateTime? AcceptInSpecializationDateTime { get; set; }

    [Column("acceptInSpecialization_SpecializationId")]
    public short AcceptInSpecializationSpecializationId { get; set; }

    [Column("acceptInSpecialization_Submit")]
    public bool AcceptInSpecializationSubmit { get; set; }

    [ForeignKey("AbiturId")]
    [InverseProperty("Accepts")]
    public virtual Abitur Abitur { get; set; } = null!;

    [ForeignKey("AcceptInGroupUserId")]
    [InverseProperty("AcceptInGroupUsers")]
    public virtual ApplicationUser? AcceptInGroupUser { get; set; }

    [ForeignKey("AcceptInSpecialityUserId")]
    [InverseProperty("AcceptInSpecialityUsers")]
    public virtual ApplicationUser? AcceptInSpecialityUser { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("Accepts")]
    public virtual GroupOfSpeciality Group { get; set; } = null!;
}
