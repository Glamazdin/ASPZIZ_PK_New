//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

//namespace ASPZIZ_PK_New.Persistence.Entities;

//[Table("aspnet_PersonalizationAllUsers")]
//public partial class AspnetPersonalizationAllUser
//{
//    [Key]
//    public Guid PathId { get; set; }

//    [Column(TypeName = "image")]
//    public byte[] PageSettings { get; set; } = null!;

//    [Column(TypeName = "datetime")]
//    public DateTime LastUpdatedDate { get; set; }

//    [ForeignKey("PathId")]
//    [InverseProperty("AspnetPersonalizationAllUser")]
//    public virtual AspnetPath Path { get; set; } = null!;
//}
