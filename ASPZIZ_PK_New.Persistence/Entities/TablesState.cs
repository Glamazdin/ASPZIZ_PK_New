using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Tables_states")]
[Index("State", Name = "IX_Tables_states_1", IsUnique = true)]
public partial class TablesState
{
    [Key]
    [Column("id")]
    public byte Id { get; set; }

    [Column("state")]
    [StringLength(50)]
    public string State { get; set; } = null!;

    [InverseProperty("StateNavigation")]
    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();

    [InverseProperty("NewStateNavigation")]
    public virtual ICollection<TablesLog> TablesLogs { get; set; } = new List<TablesLog>();
}
