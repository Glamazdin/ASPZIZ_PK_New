using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Tables_tableToQueue")]
public partial class TablesTableToQueue
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("table_id")]
    public Guid TableId { get; set; }

    [Column("queue_id")]
    public int QueueId { get; set; }

    [ForeignKey("QueueId")]
    [InverseProperty("TablesTableToQueues")]
    public virtual TablesQueue Queue { get; set; } = null!;

    [ForeignKey("TableId")]
    [InverseProperty("TablesTableToQueues")]
    public virtual Table Table { get; set; } = null!;
}
