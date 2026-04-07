using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPZIZ_PK_New.Domain.Enums;

public enum RegistrationStep
{
    [Display(Name = @"Активация пройдена")]
    SiteActivate = 0,   //пройдена активация

    [Display(Name = @"Заявление заполнено не полностью")]
    SiteNotFull = 1,        //заявление не полностью заполнено

    [Display(Name = @"Эл.кабинет")]
    SiteFull = 2,

    [Display(Name = @"Очередь")]
    Ochered = 3,

    [Display(Name = "Документы в БГУИР")]
    AdmOffice = 4,

    [Display(Name = @"Забрал(а) документы")]
    ZabralDok = 5,

    [Display(Name = @"Не зачислен(а). Документы в БГУИР")]
    NotAccepted = 6,       //не зачислен

    [Display(Name = @"Зачислен. Документы в БГУИР")]
    Accepted = 7,          //зачислен

    [Display(Name = @"Не активирован")]
    NotActivate = 255
}
