using System.ComponentModel.DataAnnotations;

namespace ASPZIZ_PK_New.Features.Admin.Models;

public class OKSKListModel
{
    [Required(ErrorMessage = "Название обязательно")]
    [StringLength(255)]
    public string Name { get; set; } = string.Empty;

    [StringLength(20)]
    public string? Code { get; set; }

    [StringLength(50)]
    public string? Abbr { get; set; }

    [StringLength(200)]
    public string? Kvalif { get; set; }
}