using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Abitur_RegStep_ChangeLog")]
public partial class AbiturRegStepChangeLog
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("abiturId")]
    public Guid AbiturId { get; set; }

    [Column("previousRegStep")]
    public byte? PreviousRegStep { get; set; }

    [Column("currentRegStep")]
    public byte? CurrentRegStep { get; set; }

    [Column("userId")]
    public Guid UserId { get; set; }

    [Column("datetimeStamp", TypeName = "datetime")]
    public DateTime DatetimeStamp { get; set; }

    [ForeignKey("AbiturId")]
    [InverseProperty("AbiturRegStepChangeLogs")]
    public virtual Abitur Abitur { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("AbiturRegStepChangeLogs")]
    public virtual ApplicationUser User { get; set; } = null!;
}
