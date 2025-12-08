using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

public partial class GroupOfSpeciality
{
    [Key]
    [Column("groupId")]
    public byte GroupId { get; set; }

    [Column("groupName")]
    [StringLength(255)]
    public string? GroupName { get; set; }

    [Column("acceptStatus")]
    public byte AcceptStatus { get; set; }

    [Column("acceptStatus_DateOfUpdate", TypeName = "datetime")]
    public DateTime? AcceptStatusDateOfUpdate { get; set; }

    [Column("acceptReportName")]
    [StringLength(255)]
    public string? AcceptReportName { get; set; }

    [Column("acceptReportStream")]
    public byte[]? AcceptReportStream { get; set; }

    [Column("acceptReport_DateOfUpdate")]
    public DateOnly? AcceptReportDateOfUpdate { get; set; }

    [Column("isLocked")]
    public bool IsLocked { get; set; }

    [Column("ekzGroupId_1")]
    public byte? EkzGroupId1 { get; set; }

    [Column("ekzGroupId_2")]
    public byte? EkzGroupId2 { get; set; }

    [Column("maxApplicationOnSpec")]
    public byte? MaxApplicationOnSpec { get; set; }

    [Column("acceptAlgorithmCode")]
    public int? AcceptAlgorithmCode { get; set; }

    [InverseProperty("Group")]
    public virtual ICollection<Accept> Accepts { get; set; } = new List<Accept>();

    [InverseProperty("Group")]
    public virtual ICollection<Register> Registers { get; set; } = new List<Register>();

    [InverseProperty("SpecGroup")]
    public virtual ICollection<VuzSpec> VuzSpecs { get; set; } = new List<VuzSpec>();
}
