using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Permission_User")]
public partial class PermissionUser
{
    [Key]
    [Column("permUserId")]
    public int PermUserId { get; set; }

    [Column("permissionId")]
    public byte PermissionId { get; set; }

    [Column("userId")]
    public Guid UserId { get; set; }

    [Column("partId")]
    public byte PartId { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("PermissionUsers")]
    public virtual ApplicationUser User { get; set; } = null!;
}
