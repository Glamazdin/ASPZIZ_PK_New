using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPZIZ_PK_New.Domain.Models;

public class PermissionsAdmin
{
    #region Специальности
    [Required]
    [Display(Name = "Специальности")]
    public bool Specialities_View { get; set; }
    #endregion

    #region Пользователи
    [Required]
    [Display(Name = "Раздел Пользователи")]
    public bool Users_View { get; set; }

    [Required]
    [Display(Name = "Пользователь")]
    public bool Users_User_View { get; set; }

    [Required]
    [Display(Name = "Пользователь. Создать.")]
    public bool Users_User_Create { get; set; }

    [Required]
    [Display(Name = "Пользователь. Удалить.")]
    public bool Users_User_Delete { get; set; }

    [Required]
    [Display(Name = "Пользователь. Блокировать.")]
    public bool Users_User_Lock { get; set; }

    [Required]
    [Display(Name = "Абитуриенты")]
    public bool Users_Abiturs_View { get; set; }

    [Required]
    [Display(Name = "Зачисление")]
    public bool Users_Accept_View { get; set; }

    [Required]
    [Display(Name = "Статистика")]
    public bool Users_Statistic_View { get; set; }

    [Required]
    [Display(Name = "Администрирование")]
    public bool Users_Admin_View { get; set; }
    #endregion

    #region Печать
    [Required]
    [Display(Name = "Печать")]
    public bool Print_View { get; set; }
    #endregion

    #region Столы
    [Required]
    [Display(Name = "Управление столами")]
    public bool Users_Tables_View { get; set; }
    #endregion

    /// <summary>
    /// Поиск отличий фалов отчетов из разных рабочих станций
    /// </summary>
    [Required]
    [Display(Name = "Сравнить файлы")]
    public bool Can_Compare_Data { get; set; }
}
