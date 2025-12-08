//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

//namespace ASPZIZ_PK_New.Persistence.Entities;

//[Table("aspnet_Users")]
//public partial class AspnetUser
//{
//    public Guid ApplicationId { get; set; }

//    [Key]
//    public Guid UserId { get; set; }

//    [StringLength(256)]
//    public string UserName { get; set; } = null!;

//    [StringLength(256)]
//    public string LoweredUserName { get; set; } = null!;

//    [StringLength(16)]
//    public string? MobileAlias { get; set; }

//    public bool IsAnonymous { get; set; }

//    [Column(TypeName = "datetime")]
//    public DateTime LastActivityDate { get; set; }

//    [ForeignKey("ApplicationId")]
//    [InverseProperty("AspnetUsers")]
//    public virtual AspnetApplication Application { get; set; } = null!;

//    [InverseProperty("User")]
//    public virtual AspnetMembership? AspnetMembership { get; set; }

//    [InverseProperty("User")]
//    public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; } = new List<AspnetPersonalizationPerUser>();

//    [InverseProperty("User")]
//    public virtual AspnetProfile? AspnetProfile { get; set; }

//    [InverseProperty("CreatedByUser")]
//    public virtual ICollection<Register> Registers { get; set; } = new List<Register>();

//    [ForeignKey("UserId")]
//    [InverseProperty("Users")]
//    public virtual ICollection<AspnetRole> Roles { get; set; } = new List<AspnetRole>();
//}
