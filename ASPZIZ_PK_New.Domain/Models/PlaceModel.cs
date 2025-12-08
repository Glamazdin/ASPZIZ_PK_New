using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPZIZ_PK_New.Domain.Models;

public class PlaceModel
{
    public bool IsChecked { get; set; }

    [Display(Name = "Аудитория")]
    public string PlaceName { get; set; }
    public string PlaceCode { get; set; }
    public byte PlaceId { get; set; }

    public string CodeForSheetOfRegistration { get; set; }
}