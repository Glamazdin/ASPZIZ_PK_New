using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Keyless]
public partial class VwGroupsOfSpeciality
{
    public byte GroupId { get; set; }

    [StringLength(255)]
    public string? GroupName { get; set; }

    public int? CountOfSpecialities { get; set; }

    [Column("EkzId_1")]
    public byte? EkzId1 { get; set; }

    [Column("EkzId_2")]
    public byte? EkzId2 { get; set; }

    public byte AcceptStatus { get; set; }

    [Column("AcceptStatus_DateOfUpdate", TypeName = "datetime")]
    public DateTime? AcceptStatusDateOfUpdate { get; set; }

    [Column("AcceptReport_DateOfUpdate")]
    public DateOnly? AcceptReportDateOfUpdate { get; set; }

    [Column("isLocked")]
    public bool IsLocked { get; set; }

    public int? CountOfPlaces { get; set; }

    [Column("CountOfPlaces_OutOfCompetition_Orphan")]
    public int? CountOfPlacesOutOfCompetitionOrphan { get; set; }

    [Column("CountOfPlaces_OutOfCompetition_Guard")]
    public int? CountOfPlacesOutOfCompetitionGuard { get; set; }
}
