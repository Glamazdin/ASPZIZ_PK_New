using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("GroupsOfSpecialities_Relationships")]
public partial class GroupsOfSpecialitiesRelationship
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("groupParentId")]
    public byte GroupParentId { get; set; }

    [Column("groupChildId")]
    public byte GroupChildId { get; set; }
}
