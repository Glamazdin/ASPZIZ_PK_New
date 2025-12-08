using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

public partial class Table
{
    [Key]
    [Column("table_id")]
    public Guid TableId { get; set; }

    [Column("duty_id")]
    public Guid DutyId { get; set; }

    [Column("state")]
    public byte State { get; set; }

    [Column("table_num")]
    public byte TableNum { get; set; }

    [ForeignKey("DutyId")]
    [InverseProperty("TableAsDuty")]
    public virtual ApplicationUser Duty { get; set; } = null!;

    [ForeignKey("State")]
    [InverseProperty("Tables")]
    public virtual TablesState StateNavigation { get; set; } = null!;

    [ForeignKey("TableId")]
    [InverseProperty("TableAsTableNavigation")]
    public virtual ApplicationUser TableNavigation { get; set; } = null!;

    [InverseProperty("Table")]
    public virtual ICollection<TablesTableToQueue> TablesTableToQueues { get; set; } = new List<TablesTableToQueue>();
}
