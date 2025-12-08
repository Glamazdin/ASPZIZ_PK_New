using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Keyless]
public partial class Prikaz
{
    [Column("vuzSpecId")]
    public short VuzSpecId { get; set; }

    [Column("Faculty_ShortName")]
    [StringLength(50)]
    public string FacultyShortName { get; set; } = null!;

    [Column("Speciality_OKSK_ShortName")]
    [StringLength(50)]
    public string? SpecialityOkskShortName { get; set; }

    [Column("dataPrikaza")]
    public DateOnly? DataPrikaza { get; set; }

    [Column("nomerPrikaza")]
    [StringLength(10)]
    public string? NomerPrikaza { get; set; }

    [Column("sobrMesto")]
    [StringLength(50)]
    public string? SobrMesto { get; set; }

    [Column("sobrData")]
    [StringLength(50)]
    public string? SobrData { get; set; }
}
