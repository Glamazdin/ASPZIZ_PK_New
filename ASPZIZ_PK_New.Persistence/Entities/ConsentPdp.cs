using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("ConsentPDP")]
public partial class ConsentPdp
{
    [Key]
    public int ConsentId { get; set; }

    [Column("name", TypeName = "text")]
    public string Name { get; set; } = null!;

    [InverseProperty("Consent")]
    public virtual ICollection<ConsentForPdp> ConsentForPdps { get; set; } = new List<ConsentForPdp>();
}
