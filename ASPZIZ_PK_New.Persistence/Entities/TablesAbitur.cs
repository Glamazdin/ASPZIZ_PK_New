using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Tables_abiturs")]
public partial class TablesAbitur
{
    [Column("queueId")]
    public int QueueId { get; set; }

    [Column("abtName")]
    [StringLength(200)]
    public string AbtName { get; set; } = null!;

    [Column("timeAdded", TypeName = "datetime")]
    public DateTime TimeAdded { get; set; }

    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("priority")]
    public int Priority { get; set; }

    [ForeignKey("QueueId")]
    [InverseProperty("TablesAbiturs")]
    public virtual TablesQueue Queue { get; set; } = null!;
}
