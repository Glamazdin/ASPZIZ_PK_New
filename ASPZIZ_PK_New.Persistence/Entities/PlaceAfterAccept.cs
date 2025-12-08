using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Place_AfterAccept")]
public partial class PlaceAfterAccept
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("specialityId")]
    public short SpecialityId { get; set; }

    [Column("placeId")]
    public byte PlaceId { get; set; }

    [ForeignKey("PlaceId")]
    [InverseProperty("PlaceAfterAccepts")]
    public virtual Place Place { get; set; } = null!;

    [ForeignKey("SpecialityId")]
    [InverseProperty("PlaceAfterAccepts")]
    public virtual VuzSpec Speciality { get; set; } = null!;
}
