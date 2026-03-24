using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPZIZ_PK_New.Features.Admin.Models
{
    public class OKSKModel
    {
        public short Id { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Аббревиатура")]
        public string Abbr { get; set; }

        [Display(Name = "Код")]
        public string Code { get; set; }

        [Display(Name = "Квалификация")]
        public string Kvalif { get; set; }

        [Display(Name = "Используется в ")]
        public int CountUsed { get; set; }

        public OKSKModel()
        {
            Id = 0;
            Name = "";
            Abbr = "";
            Code = "";
            Kvalif = "";
            CountUsed = 0;
        }
    }
}
