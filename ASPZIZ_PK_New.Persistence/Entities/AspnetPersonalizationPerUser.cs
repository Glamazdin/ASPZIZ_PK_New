//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

//namespace ASPZIZ_PK_New.Persistence.Entities;

//[Table("aspnet_PersonalizationPerUser")]
//public partial class AspnetPersonalizationPerUser
//{
//    [Key]
//    public Guid Id { get; set; }

//    public Guid? PathId { get; set; }

//    public Guid? UserId { get; set; }

//    [Column(TypeName = "image")]
//    public byte[] PageSettings { get; set; } = null!;

//    [Column(TypeName = "datetime")]
//    public DateTime LastUpdatedDate { get; set; }

//    [ForeignKey("PathId")]
//    [InverseProperty("AspnetPersonalizationPerUsers")]
//    public virtual AspnetPath? Path { get; set; }

//    [ForeignKey("UserId")]
//    [InverseProperty("AspnetPersonalizationPerUsers")]
//    public virtual AspnetUser? User { get; set; }
//}
