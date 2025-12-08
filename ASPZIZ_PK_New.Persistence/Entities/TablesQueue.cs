using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Tables_queues")]
[Index("Name", Name = "IX_Tables_queues", IsUnique = true)]
public partial class TablesQueue
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(150)]
    public string Name { get; set; } = null!;

    [InverseProperty("Queue")]
    public virtual ICollection<TablesAbitur> TablesAbiturs { get; set; } = new List<TablesAbitur>();

    [InverseProperty("Queue")]
    public virtual ICollection<TablesTableToQueue> TablesTableToQueues { get; set; } = new List<TablesTableToQueue>();
}
