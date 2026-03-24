using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ASPZIZ_PK_New.Features.Admin.Models;

public class FacultyListModel
{
    public short FacltId { get; set; }
    public string FacltNameRu { get; set; } = null!;
    public string FacltAbbrRu { get; set; } = null!;
}


