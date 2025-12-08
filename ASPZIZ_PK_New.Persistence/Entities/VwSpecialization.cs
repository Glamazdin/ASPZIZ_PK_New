using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Keyless]
public partial class VwSpecialization
{
    public short SpecializationId { get; set; }

    [Column("Specialization_OKSK_Id")]
    public short SpecializationOkskId { get; set; }

    [Column("Specialization_OKSK_Name")]
    [StringLength(255)]
    public string SpecializationOkskName { get; set; } = null!;

    [Column("Specialization_OKSK_ShortName")]
    [StringLength(50)]
    public string? SpecializationOkskShortName { get; set; }

    [Column("Specialization_OKSK_Code")]
    [StringLength(50)]
    public string? SpecializationOkskCode { get; set; }

    [Column("Specialization_OKSK_Letter")]
    [StringLength(5)]
    public string? SpecializationOkskLetter { get; set; }

    [Column("Specialization_CountOfPlaces")]
    public short SpecializationCountOfPlaces { get; set; }

    [Column("Specialization_CountOfPlaces_Orphan")]
    public short SpecializationCountOfPlacesOrphan { get; set; }

    [Column("Specialization_CountOfPlaces_Guard")]
    public short SpecializationCountOfPlacesGuard { get; set; }

    [Column("Specialization_CodeExport")]
    [StringLength(5)]
    public string? SpecializationCodeExport { get; set; }

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

    [Column("Speciality_CountOfPlaces")]
    public short SpecialityCountOfPlaces { get; set; }

    [Column("Speciality_CountOfPlaces_OutOfCompetition_Orphan")]
    public short? SpecialityCountOfPlacesOutOfCompetitionOrphan { get; set; }

    [Column("Speciality_CountOfPlaces_OutOfCompetition_Guard")]
    public short? SpecialityCountOfPlacesOutOfCompetitionGuard { get; set; }
}
