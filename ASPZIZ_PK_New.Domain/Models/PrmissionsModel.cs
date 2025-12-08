using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPZIZ_PK_New.Domain.Models;

public class PermissionsModel
{
    public object ID { get; set; }
    [Required]
    [Display(Name = "Group name")]
    public string GroupName { get; set; }

    [Display(Name = "Number of users in a group")]
    public int NumberOfUsers { get; set; }

    public PermissionsAbiturs Abiturs { get; set; } = new();

    public PermissionsAdmin Admin { get; set; } = new();
    

    [Required]
    [Display(Name = "Статистика")]
    public bool Stat { get; set; }

    [Required]
    [Display(Name = "Статистика. Для сайта.")]
    public bool Stat_Site { get; set; }

    [Required]
    [Display(Name = "Статистика. Подробно.")]
    public bool Stat_Details { get; set; }

    [Required]
    [Display(Name = "Статистика. Для печати.")]
    public bool Stat_Print { get; set; }

    [Required]
    [Display(Name = "Статистика. Количеcтво: за всё время.")]
    public bool Stat_Excel_All { get; set; }

    [Required]
    [Display(Name = "Статистика. Количество: по выбранным датам.")]
    public bool Stat_Excel_Date { get; set; }

    [Required]
    [Display(Name = "Статистика. ГИАЦ.")]
    public bool Stat_Excel_Giac { get; set; }

    [Required]
    [Display(Name = "Статистика. Для технических секретарей.")]
    public bool Stat_ForTechnicalSecretary { get; set; }

    [Required]
    [Display(Name = "Статистика. Внутренний: Информация о ходе приема документов.")]
    public bool Stat_BySpecialities { get; set; }

    [Required]
    [Display(Name = "Статистика. Сводная экзаменационная ведомость.")]
    public bool Stat_ExaminationSheet { get; set; }

    [Required]
    [Display(Name = "Статистика. Графики.")]
    public bool Stat_Graphics { get; set; }


    [Required]
    [Display(Name = "Печать")]
    public bool Print { get; set; }

    [Required]
    [Display(Name = "Администрирование")]
    public bool Adm { get; set; }

    [Required]
    [Display(Name = "Зачисление")]
    public bool Accept { get; set; }

    [Required]
    [Display(Name = "Зачисление. Автоматическое зачисление.")]
    public bool Accept_Draft_Create { get; set; }

    [Required]
    [Display(Name = "Зачисление. Удалить проект приказа.")]
    public bool Accept_Draft_Delete { get; set; }

    [Required]
    [Display(Name = "Зачисление. Отчет.")]
    public bool Accept_Report { get; set; }

    [Required]
    [Display(Name = "Зачисление. Подтвердить зачисление.")]
    public bool Accept_Submit { get; set; }

    [Required]
    [Display(Name = "Зачисление. Решение ПК.")]
    public bool Accept_ByUser { get; set; }

    [Required]
    [Display(Name = "Наблюдатель")]
    public bool Table_Supervisor { get; set; }

    [Required]
    [Display(Name = "Дежурный")]
    public bool Table_Duty { get; set; }

    [Required]
    [Display(Name = "Стол")]
    public bool Table { get; set; }

    /// <summary>
    /// Просмотр доп. информации об абитуриенте
    /// </summary>
    [Required]
    [Display(Name = "Доп Инфо.")]
    public bool Can_View_Additional_Info { get; set; }


}
