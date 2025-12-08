using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Keyless]
public partial class VwEntrantsOfInnerExam
{
    [StringLength(50)]
    public string? Code { get; set; }

    [StringLength(255)]
    public string Surname { get; set; } = null!;

    [StringLength(255)]
    public string Name { get; set; } = null!;

    [StringLength(255)]
    public string? Patronymic { get; set; }

    [StringLength(10)]
    public string? PassportSerial { get; set; }

    [StringLength(20)]
    public string? PassportNumber { get; set; }

    [Column("pasInoe")]
    [StringLength(255)]
    public string? PasInoe { get; set; }

    public bool ExamLanguageId { get; set; }

    [Column("EducationForm_Id")]
    public byte EducationFormId { get; set; }

    [Column("EducationForm_Name")]
    [StringLength(50)]
    public string EducationFormName { get; set; } = null!;

    [Column("EducationTerm_Id")]
    public byte EducationTermId { get; set; }

    [Column("EducationTerm_Name")]
    [StringLength(50)]
    public string EducationTermName { get; set; } = null!;

    [Column("Faculty_Id")]
    public short FacultyId { get; set; }

    [Column("Faculty_Name")]
    [StringLength(255)]
    public string FacultyName { get; set; } = null!;

    public short SpecialityId { get; set; }

    [Column("Speciality_OKSK_Code")]
    [StringLength(20)]
    public string? SpecialityOkskCode { get; set; }

    [Column("Speciality_OKSK_Name")]
    [StringLength(255)]
    public string SpecialityOkskName { get; set; } = null!;

    [StringLength(16)]
    public string? ExamLanguageName { get; set; }

    public byte EkzId { get; set; }

    [StringLength(50)]
    public string ExamName { get; set; } = null!;

    public byte? ExamMark { get; set; }

    public byte ExamTypeId { get; set; }

    [StringLength(300)]
    public string ExamTypeName { get; set; } = null!;
}
