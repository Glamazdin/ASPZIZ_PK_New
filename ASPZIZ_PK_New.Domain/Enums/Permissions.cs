using System;
using System.Collections.Generic;
using System.Text;

namespace ASPZIZ_PK_New.Domain.Enums;

public enum PermissionsAspziz : byte
{
    // Закладка Адитуриенты
    Site_View = 10,
    Site_Create = 11,
    Site_Edit = 12,
    Site_Delete = 13,
    Site_AddToTurn = 14,

    Turn_View = 20,
    Turn_Create = 21,
    Turn_Edit = 22,
    Turn_Delete = 23,
    Turn_Admit = 25,


    Admission_View = 30,
    Admission_Edit = 32,
    Admission_Remove = 36,
    Admission_Accept = 37,

    Accepted_View = 40,
    Accepted_Edit = 42,
    Accepted_Remove = 46,
    Accepted_Accept = 47,

    NotAccepted_View = 50,
    NotAccepted_Edit = 52,
    NotAccepted_Remove = 56,
    NotAccepted_Accept = 57,

    Zabr_View = 60,
    Zabr_Delete = 63,
    Zabr_AddToOcher = 64,

    // Закладка Статистика

    Stat = 100,
    Stat_Site = 101,
    Stat_Details = 102,
    Stat_Print = 103,
    Stat_Excel_All = 104,
    Stat_Excel_Date = 105,
    Stat_Excel_Giac = 106,

    Stat_ForTechnicalSecretary = 107,
    Stat_BySpecialities = 108,
    Stat_ExaminationSheet = 109,
    Stat_Graphics = 111,

    /// <summary>
    /// Просмотр доп информации об абитуриенте
    /// </summary>
    Stat_Additional_Info = 112,


    // закладка Администрирование
    Adm = 200,
    Adm_Specialities_View = 201,
    Adm_Users_View = 202,
    Adm_Users_User_View = 203,
    Adm_Users_User_Create = 211,
    Adm_Users_User_Delete = 212,
    Adm_Users_User_Lock = 213,
    Adm_Users_Abiturs_View = 204,
    Adm_Users_Accept_View = 205,
    Adm_Users_Statistic_View = 206,
    Adm_Users_Admin_View = 207,
    Adm_Users_Tables_View = 208,
    Adm_Print_View = 210,
    /// <summary>
    /// Поиск отличий фалов отчетов из разных рабочих станций
    /// </summary>
    Adm_Compare_Data = 216,

    // закладка Зачисление
    Accept = 220,
    Accept_Draft_Create = 221,
    Accept_Draft_Delete = 222,
    Accept_Report = 223,
    Accept_Submit = 224,
    Accept_ByUser = 225,

    // управление столами
    Table_Supervisor = 230,
    Table_Duty = 231,
    Table = 232,

    Print = 250
}
