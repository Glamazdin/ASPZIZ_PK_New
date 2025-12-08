using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("ConsentForPDP")]
public partial class ConsentForPdp
{
    [Column("abiturId")]
    public Guid AbiturId { get; set; }

    public int ConsentId { get; set; }

    [Column("result")]
    public bool Result { get; set; }

    [Key]
    [Column("consentAbiturId")]
    public Guid ConsentAbiturId { get; set; }

    [ForeignKey("AbiturId")]
    [InverseProperty("ConsentForPdps")]
    public virtual Abitur Abitur { get; set; } = null!;

    [ForeignKey("ConsentId")]
    [InverseProperty("ConsentForPdps")]
    public virtual ConsentPdp Consent { get; set; } = null!;
}
