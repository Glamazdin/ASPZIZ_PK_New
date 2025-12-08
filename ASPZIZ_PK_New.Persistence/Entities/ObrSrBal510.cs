using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Obr_SrBal5_10")]
public partial class ObrSrBal510
{
    [Key]
    [Column("srBal_id")]
    public byte SrBalId { get; set; }

    [Column("oc5", TypeName = "decimal(2, 1)")]
    public decimal Oc5 { get; set; }

    [Column("oc10", TypeName = "decimal(3, 1)")]
    public decimal Oc10 { get; set; }
}
