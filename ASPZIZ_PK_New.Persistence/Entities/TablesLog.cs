using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Tables_logs")]
public partial class TablesLog
{
    [Column("table_id")]
    public Guid TableId { get; set; }

    [Column("changer_id")]
    public Guid ChangerId { get; set; }

    [Column("new_state")]
    public byte NewState { get; set; }

    [Column("time_changed", TypeName = "datetime")]
    public DateTime TimeChanged { get; set; }

    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("message")]
    [StringLength(250)]
    public string? Message { get; set; }

    [ForeignKey("ChangerId")]
    [InverseProperty("TablesLogAsChanger")]
    public virtual ApplicationUser Changer { get; set; } = null!;

    [ForeignKey("NewState")]
    [InverseProperty("TablesLogs")]
    public virtual TablesState NewStateNavigation { get; set; } = null!;

    [ForeignKey("TableId")]
    [InverseProperty("TablesLogAsTable")]
    public virtual ApplicationUser Table { get; set; } = null!;
}
