//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

//namespace ASPZIZ_PK_New.Persistence.Entities;

//[Table("aspnet_Membership")]
//public partial class AspnetMembership
//{
//    public Guid ApplicationId { get; set; }

//    [Key]
//    public Guid UserId { get; set; }

//    [StringLength(128)]
//    public string Password { get; set; } = null!;

//    public int PasswordFormat { get; set; }

//    [StringLength(128)]
//    public string PasswordSalt { get; set; } = null!;

//    [Column("MobilePIN")]
//    [StringLength(16)]
//    public string? MobilePin { get; set; }

//    [StringLength(256)]
//    public string? Email { get; set; }

//    [StringLength(256)]
//    public string? LoweredEmail { get; set; }

//    [StringLength(256)]
//    public string? PasswordQuestion { get; set; }

//    [StringLength(128)]
//    public string? PasswordAnswer { get; set; }

//    public bool IsApproved { get; set; }

//    public bool IsLockedOut { get; set; }

//    [Column(TypeName = "datetime")]
//    public DateTime CreateDate { get; set; }

//    [Column(TypeName = "datetime")]
//    public DateTime LastLoginDate { get; set; }

//    [Column(TypeName = "datetime")]
//    public DateTime LastPasswordChangedDate { get; set; }

//    [Column(TypeName = "datetime")]
//    public DateTime LastLockoutDate { get; set; }

//    public int FailedPasswordAttemptCount { get; set; }

//    [Column(TypeName = "datetime")]
//    public DateTime FailedPasswordAttemptWindowStart { get; set; }

//    public int FailedPasswordAnswerAttemptCount { get; set; }

//    [Column(TypeName = "datetime")]
//    public DateTime FailedPasswordAnswerAttemptWindowStart { get; set; }

//    [Column(TypeName = "ntext")]
//    public string? Comment { get; set; }

//    [InverseProperty("User")]
//    public virtual ICollection<AbiturRegStepChangeLog> AbiturRegStepChangeLogs { get; set; } = new List<AbiturRegStepChangeLog>();

//    //[InverseProperty("CreatedByNavigation")]
//    //public virtual ICollection<Abitur> Abiturs { get; set; } = new List<Abitur>();

//    //[InverseProperty("AcceptInGroupUser")]
//    //public virtual ICollection<Accept> AcceptAcceptInGroupUsers { get; set; } = new List<Accept>();

//    //[InverseProperty("AcceptInSpecialityUser")]
//    //public virtual ICollection<Accept> AcceptAcceptInSpecialityUsers { get; set; } = new List<Accept>();

//    //[ForeignKey("ApplicationId")]
//    //[InverseProperty("AspnetMemberships")]
//    //public virtual AspnetApplication Application { get; set; } = null!;

//    //[InverseProperty("User")]
//    //public virtual ICollection<PermissionUser> PermissionUsers { get; set; } = new List<PermissionUser>();

//    //[InverseProperty("User")]
//    //public virtual ICollection<PlaceUser> PlaceUsers { get; set; } = new List<PlaceUser>();

//    //[InverseProperty("Duty")]
//    //public virtual ICollection<Table> TableDuties { get; set; } = new List<Table>();

//    //[InverseProperty("TableNavigation")]
//    //public virtual Table? TableTableNavigation { get; set; }

//    //[InverseProperty("Changer")]
//    //public virtual ICollection<TablesLog> TablesLogChangers { get; set; } = new List<TablesLog>();

//    //[InverseProperty("Table")]
//    //public virtual ICollection<TablesLog> TablesLogTables { get; set; } = new List<TablesLog>();

//    //[ForeignKey("UserId")]
//    //[InverseProperty("AspnetMembership")]
//    //public virtual AspnetUser User { get; set; } = null!;
//}
