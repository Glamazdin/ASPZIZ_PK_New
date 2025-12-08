using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

public partial class Customer
{
    [Key]
    [Column("customerId")]
    public short CustomerId { get; set; }

    [Column("customerFullName")]
    [StringLength(300)]
    public string? CustomerFullName { get; set; }

    [Column("customerShortName")]
    [StringLength(50)]
    public string? CustomerShortName { get; set; }

    [Column("UNP")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Unp { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<VuzSpec> VuzSpecs { get; set; } = new List<VuzSpec>();
}
