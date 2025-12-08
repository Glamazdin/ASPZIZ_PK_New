using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("StatSpecGroup")]
[Index("StatGroupName", Name = "I_StatName_StatSpecGroup", IsUnique = true)]
public partial class StatSpecGroup
{
    [Key]
    [Column("statGroupId")]
    public int StatGroupId { get; set; }

    [Column("statGroupName")]
    [StringLength(255)]
    public string StatGroupName { get; set; } = null!;

    public int? SortOrder { get; set; }

    [Column("siteIsLocked")]
    public bool? SiteIsLocked { get; set; }

    [Column("siteOrderUrl")]
    [StringLength(255)]
    public string? SiteOrderUrl { get; set; }

    [Column("siteStatGroupName")]
    [StringLength(255)]
    public string? SiteStatGroupName { get; set; }

    [Column("siteStatGroupTitle")]
    [StringLength(255)]
    public string? SiteStatGroupTitle { get; set; }

    [Column("siteStatPageName")]
    [StringLength(255)]
    public string? SiteStatPageName { get; set; }

    [InverseProperty("StatSpecGroup")]
    public virtual ICollection<VuzSpec> VuzSpecs { get; set; } = new List<VuzSpec>();
}
