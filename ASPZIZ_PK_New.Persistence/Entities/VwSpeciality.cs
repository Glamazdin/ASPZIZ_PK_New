using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Keyless]
public partial class VwSpeciality
{
    [Column("Speciality_OKSK_Id")]
    public short SpecialityOkskId { get; set; }

    [Column("Speciality_OKSK_Name")]
    [StringLength(255)]
    public string SpecialityOkskName { get; set; } = null!;

    [Column("Speciality_OKSK_Code")]
    [StringLength(20)]
    public string? SpecialityOkskCode { get; set; }

    [Column("Speciality_OKSK_ShortName")]
    [StringLength(50)]
    public string? SpecialityOkskShortName { get; set; }

    [Column("EducationForm_Id")]
    public byte EducationFormId { get; set; }

    [Column("EducationForm_Name")]
    [StringLength(50)]
    public string EducationFormName { get; set; } = null!;

    [Column("Faculty_Id")]
    public short FacultyId { get; set; }

    [Column("Faculty_Name")]
    [StringLength(255)]
    public string FacultyName { get; set; } = null!;

    [Column("Faculty_ShortName")]
    [StringLength(50)]
    public string FacultyShortName { get; set; } = null!;

    [Column("EducationTerm_Id")]
    public byte EducationTermId { get; set; }

    [Column("EducationTerm_Name")]
    [StringLength(50)]
    public string EducationTermName { get; set; } = null!;

    public short SpecialityId { get; set; }

    public bool IsPaySpeciality { get; set; }

    public bool IsTargetSpeciality { get; set; }

    public short CountOfPlaces { get; set; }

    [Column("countOfPlaces_OutOfCompetition_Orphan")]
    public short? CountOfPlacesOutOfCompetitionOrphan { get; set; }

    [Column("countOfPlaces_OutOfCompetition_Guard")]
    public short? CountOfPlacesOutOfCompetitionGuard { get; set; }

    [Column("Group_Id")]
    public byte GroupId { get; set; }

    [Column("Group_Name")]
    [StringLength(255)]
    public string? GroupName { get; set; }

    [StringLength(32)]
    public string? ColorForStatistics { get; set; }

    [Column("specCode")]
    [StringLength(10)]
    public string? SpecCode { get; set; }

    [Column("facltLotusCode")]
    [StringLength(10)]
    public string? FacltLotusCode { get; set; }

    [Column("obrLotusCode")]
    [StringLength(10)]
    public string? ObrLotusCode { get; set; }

    [Column("specLotusCode")]
    [StringLength(10)]
    public string? SpecLotusCode { get; set; }

    [Column("specLotusGroupId")]
    public byte? SpecLotusGroupId { get; set; }

    [Column("customerFullName")]
    [StringLength(300)]
    public string? CustomerFullName { get; set; }

    [Column("customerShortName")]
    [StringLength(50)]
    public string? CustomerShortName { get; set; }

    [Column("customerId")]
    public short? CustomerId { get; set; }

    public short OutOfCompetitionAll { get; set; }
}
