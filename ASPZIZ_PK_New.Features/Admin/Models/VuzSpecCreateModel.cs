using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ASPZIZ_PK_New.Features.Admin.Models;
public class VuzSpecCreateModel

{
    public short VuzSpecId { get; set; }
    [Range(1, short.MaxValue,  ErrorMessage = "Факультет обязателен")]
    public short FacltId { get; set; }

    [Range(1, short.MaxValue, ErrorMessage = "Специальность обязана быть выбрана")]
    public short SpecId { get; set; }

    [Range(1, short.MaxValue)]
    public short KolvoMest { get; set; } = 0;

    public bool OplataB { get; set; } = false;

    public bool CelevB { get; set; } = false;

    // optional: группа специальностей (0 - без группы)
    [Range(1, byte.MaxValue, ErrorMessage ="Выберите группу специальностей")]
    public byte SpecGroupId { get; set; } = 0;

    public class GroupOfSpecialityModel
    {
        public byte GroupId { get; set; }
        public string? GroupName { get; set; }
    }
}