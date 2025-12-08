using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Lgoti_VneKonk")]
public partial class LgotiVneKonk
{
    [Key]
    [Column("vkId")]
    public byte VkId { get; set; }

    [Column("vkName_Short")]
    [StringLength(200)]
    public string VkNameShort { get; set; } = null!;

    [Column("vkName_Full")]
    [StringLength(800)]
    public string VkNameFull { get; set; } = null!;

    [InverseProperty("VneKonk")]
    public virtual ICollection<Abitur> Abiturs { get; set; } = new List<Abitur>();
}
