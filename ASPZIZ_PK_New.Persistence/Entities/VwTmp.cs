using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Keyless]
public partial class VwTmp
{
    [Column("Speciality_OKSK_Id")]
    public short SpecialityOkskId { get; set; }

    [Column("Speciality_OKSK_Name")]
    [StringLength(255)]
    public string SpecialityOkskName { get; set; } = null!;

    [Column("Speciality_OKSK_ShortName")]
    [StringLength(50)]
    public string? SpecialityOkskShortName { get; set; }

    [Column("EducationForm_Name")]
    [StringLength(50)]
    public string EducationFormName { get; set; } = null!;

    [Column("Faculty_ShortName")]
    [StringLength(50)]
    public string FacultyShortName { get; set; } = null!;

    [Column("EducationTerm_Name")]
    [StringLength(50)]
    public string EducationTermName { get; set; } = null!;

    public short SpecialityId { get; set; }

    public bool IsPaySpeciality { get; set; }

    public short CountOfPlaces { get; set; }

    [Column("specGroupId")]
    public byte SpecGroupId { get; set; }
}
