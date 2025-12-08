using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Place_User")]
public partial class PlaceUser
{
    [Key]
    [Column("userPlaceId")]
    public int UserPlaceId { get; set; }

    [Column("placeId")]
    public byte PlaceId { get; set; }

    [Column("userId")]
    public Guid UserId { get; set; }

    [ForeignKey("PlaceId")]
    [InverseProperty("PlaceUsers")]
    public virtual Place Place { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("PlaceUsers")]
    public virtual ApplicationUser User { get; set; } = null!;
}
