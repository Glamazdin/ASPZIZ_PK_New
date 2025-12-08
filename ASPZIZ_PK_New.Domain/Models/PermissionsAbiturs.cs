using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPZIZ_PK_New.Domain.Models;

public class PermissionsAbiturs
{
    #region Эл.кабинет
    [Required]
    [Display(Name = "Эл.кабинет")]
    public bool Site_View { get; set; }

    [Required]
    [Display(Name = "Эл.кабинет. Редактировать.")]
    public bool Site_Edit { get; set; }

    [Required]
    [Display(Name = "Эл.кабинет. Удалять.")]
    public bool Site_Del { get; set; }

    [Required]
    [Display(Name = "Эл.кабинет. Создать кабинет.")]
    public bool Site_Create { get; set; }

    [Required]
    [Display(Name = "Эл.кабинет. Добавить в очередь.")]
    public bool Site_AddToTurn { get; set; }
    #endregion

    #region Очередь
    [Required]
    [Display(Name = "Очередь")]
    public bool Turn_View { get; set; }

    [Required]
    [Display(Name = "Очередь. Создать.")]
    public bool Turn_Create { get; set; }

    [Required]
    [Display(Name = "Очередь. Редактировать.")]
    public bool Turn_Edit { get; set; }

    [Required]
    [Display(Name = "Очередь. Удалять.")]
    public bool Turn_Delete { get; set; }

    [Required]
    [Display(Name = "Очередь. Принять документы.")]
    public bool Turn_Admit { get; set; }
    #endregion

    #region Принятые
    [Required]
    [Display(Name = "Принятые")]
    public bool Admission_View { get; set; }

    [Required]
    [Display(Name = "Принятые. Редактировать.")]
    public bool Admission_Edit { get; set; }

    [Required]
    [Display(Name = "Принятые. Выдать документы.")]
    public bool Admission_Remove { get; set; }

    [Required]
    [Display(Name = "Принятые. Зачислять.")]
    public bool Admission_Accept { get; set; }
    #endregion

    #region Зачисленные
    [Required]
    [Display(Name = "Зачисленные")]
    public bool Accepted_View { get; set; }

    [Required]
    [Display(Name = "Зачисленные. Редактировать.")]
    public bool Accepted_Edit { get; set; }

    [Required]
    [Display(Name = "Зачисленные. Выдать документы.")]
    public bool Accepted_Remove { get; set; }

    [Required]
    [Display(Name = "Зачисленные. Перезачислить.")]
    public bool Accepted_Accept { get; set; }
    #endregion

    #region Не зачисленные
    [Required]
    [Display(Name = "Не зачисленные")]
    public bool NotAccepted_View { get; set; }

    [Required]
    [Display(Name = "Не зачисленные. Редактировать.")]
    public bool NotAccepted_Edit { get; set; }

    [Required]
    [Display(Name = "Не зачисленные. Выдать документы.")]
    public bool NotAccepted_Remove { get; set; }

    [Required]
    [Display(Name = "Не зачисленные. Зачислить.")]
    public bool NotAccepted_Accept { get; set; }
    #endregion

    #region Забранные
    [Required]
    [Display(Name = "Забранные")]
    public bool Zabr_View { get; set; }

    [Required]
    [Display(Name = "Забранные. Удалять.")]
    public bool Zabr_Delete { get; set; }

    [Required]
    [Display(Name = "Забранные. Добавить в очередь.")]
    public bool Zabr_AddToTurn { get; set; }
    #endregion

}
