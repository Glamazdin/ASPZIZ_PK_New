using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Gragdanstvo")]
public partial class Gragdanstvo
{
    [Key]
    [Column("gragdId")]
    public byte GragdId { get; set; }

    [Column("gragdName")]
    [StringLength(100)]
    public string GragdName { get; set; } = null!;
}
