using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Place")]
public partial class Place
{
    [Key]
    [Column("placeId")]
    public byte PlaceId { get; set; }

    [Column("placeName")]
    [StringLength(200)]
    public string PlaceName { get; set; } = null!;

    [Column("placeCode")]
    [StringLength(50)]
    public string PlaceCode { get; set; } = null!;

    [Column("placeCodeForSheetOfRegistration")]
    [StringLength(50)]
    public string? PlaceCodeForSheetOfRegistration { get; set; }

    [InverseProperty("Place")]
    public virtual ICollection<Abitur> Abiturs { get; set; } = new List<Abitur>();

    [InverseProperty("Place")]
    public virtual ICollection<PlaceAfterAccept> PlaceAfterAccepts { get; set; } = new List<PlaceAfterAccept>();

    //[InverseProperty("Place")]
    //public virtual ICollection<PlaceUser> PlaceUsers { get; set; } = new List<PlaceUser>();

    //[InverseProperty("Place")]
    public virtual ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
}
