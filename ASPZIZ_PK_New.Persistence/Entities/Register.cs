using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Register")]
public partial class Register
{
    [Key]
    [Column("registerId")]
    public int RegisterId { get; set; }

    [Column("entrantId")]
    public Guid EntrantId { get; set; }

    [Column("createdByUserId")]
    public Guid CreatedByUserId { get; set; }

    [Column("groupId")]
    public byte GroupId { get; set; }

    [Column("entrantCode")]
    [StringLength(50)]
    public string EntrantCode { get; set; } = null!;

    [Column("dateOfAccept", TypeName = "datetime")]
    public DateTime DateOfAccept { get; set; }

    [Column("entrantInitials")]
    [StringLength(300)]
    public string EntrantInitials { get; set; } = null!;

    [Column("nationality")]
    [StringLength(255)]
    public string Nationality { get; set; } = null!;

    [Column("certificates")]
    [StringLength(100)]
    public string Certificates { get; set; } = null!;

    [Column("privileges")]
    [StringLength(300)]
    public string Privileges { get; set; } = null!;

    [Column("adress")]
    [StringLength(500)]
    public string Adress { get; set; } = null!;

    [Column("isTarget")]
    public bool IsTarget { get; set; }

    [Column("isEnrolled")]
    public bool IsEnrolled { get; set; }

    [Column("isReturned")]
    public bool IsReturned { get; set; }

    [Column("isSecondDegree")]
    public bool? IsSecondDegree { get; set; }

    [ForeignKey("CreatedByUserId")]
    [InverseProperty("Registers")]
    public virtual ApplicationUser CreatedByUser { get; set; } = null!;

    [ForeignKey("GroupId")]
    [InverseProperty("Registers")]
    public virtual GroupOfSpeciality Group { get; set; } = null!;
}
