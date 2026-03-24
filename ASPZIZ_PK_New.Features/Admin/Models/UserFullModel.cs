using ASPZIZ_PK_New.Features.Helpers;
using System.ComponentModel.DataAnnotations;

namespace ASPZIZ_PK_New.Features.Admin.Models;

public class UserFullModel
{
    public Guid Id { get; set; }

    [Required(ErrorMessage ="Поле Логин обязательно для заполнения")]
    public string Login { get; set; }

    [Required(ErrorMessage ="Поле Полное имя обязательно для заполнения")]     
    public string? FullName { get; set; }
    public Place? Place { get; set; }

    [StrongPassword]
    public string Password { get; set; } = String.Empty;
    public bool Site_View { get; set; }
    public bool Site_Create { get; set; }
    public bool Site_Edit { get; set; }
    public bool Site_Delete { get; set; }
    public bool Site_AddToTurn { get; set; }

    public bool Turn_View { get; set; }
    public bool Turn_Edit { get; set; }
    public bool Turn_Create { get; set; }
    public bool Turn_Delete { get; set; }
    public bool Turn_Admit { get; set; }


    public bool Admission_View { get; set; }
    public bool Admission_Edit { get; set; }
    public bool Admission_Remove { get; set; }
    public bool Admission_Accept { get; set; }

    public bool Accepted_View { get; set; }
    public bool Accepted_Edit { get; set; }
    public bool Accepted_Remove { get; set; }
    public bool Accepted_Accept { get; set; }

    public bool NotAccepted_View { get; set; }
    public bool NotAccepted_Edit { get; set; }
    public bool NotAccepted_Remove { get; set; }
    public bool NotAccepted_Accept { get; set; }

    public bool Zabr_View { get; set; }
    public bool Zabr_Delete { get; set; }
    public bool Zabr_AddToOcher { get; set; }

    
    /// <summary>
    /// Закладка Статистика
    /// </summary>
    public bool Stat { get; set; }
    /// <summary>
    /// Статистика для сайта
    /// </summary>
    public bool Stat_Site { get; set; } // = 101,
    public bool Stat_Details { get; set; } // = 102,
    public bool Stat_Print { get; set; } // = 103,
    public bool Stat_Excel_All { get; set; } // = 104,
    public bool Stat_Excel_Date { get; set; } // = 105,
    public bool Stat_Excel_Giac { get; set; } // = 106,

    public bool Stat_ForTechnicalSecretary { get; set; } // = 107,
    public bool Stat_BySpecialities { get; set; } // = 108,
    public bool Stat_ExaminationSheet { get; set; } // = 109,
    public bool Stat_Graphics { get; set; } // = 111,

    /// <summary>
    /// Просмотр доп информации об абитуриенте
    /// </summary>
    public bool Stat_Additional_Info { get; set; } // = 112,


    
    /// <summary>
    /// раздел Администрирование
    /// </summary>
    public bool Adm { get; set; } // = 200,
    /// <summary>
    /// Раздел Специальности
    /// </summary>
    public bool Adm_Specialities_View { get; set; } // = 201,
    /// <summary>
    /// Раздел "Управление пользователями"
    /// </summary>
    public bool Adm_Users_View { get; set; } // = 202,
    /// <summary>
    /// Управление пользователями - закладка Пользователь
    /// </summary>
    public bool Adm_Users_User_View { get; set; } // = 203,
    /// <summary>
    /// Управление пользователями - создание пользователя 
    /// </summary>
    public bool Adm_Users_User_Create { get; set; } // = 211,
    /// <summary>
    /// Управление пользователями - удаление пользователя 
    /// </summary>
    public bool Adm_Users_User_Delete { get; set; } // = 212,
    /// <summary>
    /// Управление пользователями - бллокировка пользователя 
    /// </summary>
    public bool Adm_Users_User_Lock { get; set; } // = 213,
    /// <summary>
    /// Управление пользователями - закладка Абитуриенты 
    /// </summary>
    public bool Adm_Users_Abiturs_View { get; set; } // = 204,
    /// <summary>
    /// Управление пользователями - закладка Зачисление 
    /// </summary>
    public bool Adm_Users_Accept_View { get; set; } // = 205,
    /// <summary>
    /// Управление пользователями - закладка Статистика
    /// </summary>
    public bool Adm_Users_Statistic_View { get; set; } // = 206,
    /// <summary>
    /// Управление пользователями - закладка Администрирование
    /// </summary>
    public bool Adm_Users_Admin_View { get; set; } // = 207,
    /// <summary>
    /// Управление пользователями - управление столами
    /// </summary>
    public bool Adm_Users_Tables_View { get; set; } // = 208,
    /// <summary>
    /// Печать
    /// </summary>
    public bool Adm_Print_View { get; set; } // = 210,
    /// <summary>
    /// Поиск отличий фалов отчетов из разных рабочих станций
    /// </summary>
    public bool Adm_Compare_Data { get; set; } // = 216,

    
    /// <summary>
    /// допуск к странице Зачисление
    /// </summary>
    public bool Accept { get; set; } // = 220,
    public bool Accept_Draft_Create { get; set; } // = 221,
    public bool Accept_Draft_Delete { get; set; } // = 222,
    public bool Accept_Report { get; set; } // = 223,
    public bool Accept_Submit { get; set; } // = 224,
    public bool Accept_ByUser { get; set; } // = 225,

    // управление столами
    public bool Table_Supervisor { get; set; } // = 230,
    public bool Table_Duty { get; set; } // = 231,
    public bool Table { get; set; } // = 232,

    public bool Print { get; set; } // = 250


    public UserFullModel(Guid Id, string Login, string? FullName, Place Place) 
    {
        this.Id = Id;
        this.Login = Login;        
        this.FullName = FullName;
        this.Place = Place;
    }
}
