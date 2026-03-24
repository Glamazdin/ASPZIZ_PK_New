using DA = System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace ASPZIZ_PK_New.UI.Extensions;

public static class ClaimsPrincipalExtensions
{
    extension (ClaimsPrincipal user)
    {
        [DA:Required]
        [DA:Display(Name = "Статистика")]
        public bool Stat => user.HasClaim("Stat","true");

        [DA:Required]
        [DA:Display(Name = "Статистика. Для сайта.")]
        public bool Stat_Site => user.HasClaim("Stat_Site", "true");

        [DA:Required]
        [DA:Display(Name = "Статистика. Подробно.")]
        public bool Stat_Details => user.HasClaim("Stat_Details", "true");

        [DA:Required]
        [DA:Display(Name = "Статистика. Для печати.")]
        public bool Stat_Print => user.HasClaim("Stat_Print", "true");

        [DA:Required]
        [DA:Display(Name = "Статистика. Количеcтво: за всё время.")]
        public bool Stat_Excel_All => user.HasClaim("Stat_Excel_All", "true");

        [DA:Required]
        [DA:Display(Name = "Статистика. Количество: по выбранным датам.")]
        public bool Stat_Excel_Date => user.HasClaim("Stat_Excel_Date", "true");

        [DA:Required]
        [DA:Display(Name = "Статистика. ГИАЦ.")]
        public bool Stat_Excel_Giac => user.HasClaim("Stat_Excel_Giac", "true");

        [DA:Required]
        [DA:Display(Name = "Статистика. Для технических секретарей.")]
        public bool Stat_ForTechnicalSecretary => user.HasClaim("Stat_ForTechnicalSecretary", "true");

        [DA:Required]
        [DA:Display(Name = "Статистика. Внутренний: Информация о ходе приема документов.")]
        public bool Stat_BySpecialities => user.HasClaim("Stat_BySpecialities", "true");

        [DA:Required]
        [DA:Display(Name = "Статистика. Сводная экзаменационная ведомость.")]
        public bool Stat_ExaminationSheet => user.HasClaim("Stat_ExaminationSheet", "true");

        [DA:Required]
        [DA:Display(Name = "Статистика. Графики.")]
        public bool Stat_Graphics => user.HasClaim("Stat_Graphics", "true");


        [DA:Required]
        [DA:Display(Name = "Печать")]
        public bool Print => user.HasClaim("Print", "true");

        [DA:Required]
        [DA:Display(Name = "Администрирование")]
        public bool Adm => user.HasClaim("Adm", "true");

        [DA:Required]
        [DA:Display(Name = "Зачисление")]
        public bool Accept => user.HasClaim("Accept", "true");

        [DA:Required]
        [DA:Display(Name = "Зачисление. Автоматическое зачисление.")]
        public bool Accept_Draft_Create => user.HasClaim("Accept_Draft_Create", "true");

        [DA:Required]
        [DA:Display(Name = "Зачисление. Удалить проект приказа.")]
        public bool Accept_Draft_Delete => user.HasClaim("Accept_Draft_Delete", "true");

        [DA:Required]
        [DA:Display(Name = "Зачисление. Отчет.")]
        public bool Accept_Report => user.HasClaim("Accept_Report", "true");

        [DA:Required]
        [DA:Display(Name = "Зачисление. Подтвердить зачисление.")]
        public bool Accept_Submit => user.HasClaim("Accept_Submit", "true");

        [DA:Required]
        [DA:Display(Name = "Зачисление. Решение ПК.")]
        public bool Accept_ByUser => user.HasClaim("Accept_ByUser", "true");

        [DA:Required]
        [DA:Display(Name = "Наблюдатель")]
        public bool Table_Supervisor => user.HasClaim("Table_Supervisor", "true");

        [DA:Required]
        [DA:Display(Name = "Дежурный")]
        public bool Table_Duty => user.HasClaim("Table_Duty", "true");

        [DA:Required]
        [DA:Display(Name = "Стол")]
        public bool Table => user.HasClaim("Table", "true");

        /// <summary>
        /// Просмотр доп. информации об абитуриенте
        /// </summary>
        [DA:Required]
        [DA:Display(Name = "Доп Инфо.")]
        public bool Can_View_Additional_Info => user.HasClaim("Can_View_Additional_Info", "true");

        
        //Admin
        
        /// <summary>
        /// Поиск отличий файлов отчетов из разных рабочих станций
        /// </summary>
        [DA:Required]
        [DA:Display(Name = "Сравнить файлы")]
        public bool Adm_Compare_Data => user.HasClaim("Adm_Compare_Data", "true");

        #region Специальности
        [DA:Required]
        [DA:Display(Name = "Специальности")]
        public bool Adm_Specialities_View => user.HasClaim("Adm_Specialities_View", "true");
        #endregion

        #region Пользователи
        [DA:Required]
        [DA:Display(Name = "Раздел Пользователи")]
        public bool Adm_Users_View => user.HasClaim("Adm_Users_View", "true");

        [DA:Required]
        [DA:Display(Name = "Пользователь")]
        public bool Adm_Users_User_View => user.HasClaim("Adm_Users_User_View", "true");

        [DA:Required]
        [DA:Display(Name = "Пользователь. Создать.")]
        public bool Adm_Users_User_Create => user.HasClaim("Adm_Users_User_Create", "true");

        [DA:Required]
        [DA:Display(Name = "Пользователь. Удалить.")]
        public bool Adm_Users_User_Delete => user.HasClaim("Adm_Users_User_Delete", "true");

        [DA:Required]
        [DA:Display(Name = "Пользователь. Блокировать.")]
        public bool Adm_Users_User_Lock => user.HasClaim("Adm_Users_User_Lock", "true");

        [DA:Required]
        [DA:Display(Name = "Абитуриенты")]
        public bool Adm_Users_Abiturs_View => user.HasClaim("Adm_Users_Abiturs_View", "true");

        [DA:Required]
        [DA:Display(Name = "Зачисление")]
        public bool Adm_Users_Accept_View => user.HasClaim("Adm_Users_Accept_View", "true");

        [DA:Required]
        [DA:Display(Name = "Статистика")]
        public bool Adm_Users_Statistic_View => user.HasClaim("Adm_Users_Statistic_View", "true");

        [DA:Required]
        [DA:Display(Name = "Администрирование")]
        public bool Adm_Users_Admin_View => user.HasClaim("adminAdm_Users_Admin_View", "true");
        #endregion

        #region Печать
        [DA:Required]
        [DA:Display(Name = "Печать")]
        public bool Adm_Print_View => user.HasClaim("Adm_Print_View", "true");
        #endregion

        #region Столы
        [DA:Required]
        [DA:Display(Name = "Управление столами")]
        public bool Adm_Users_Tables_View => user.HasClaim("Adm_Users_Tables_View", "true");
        #endregion

        // Abitur

        #region Эл.кабинет
        [DA:Required]
        [DA:Display(Name = "Эл.кабинет")]
        public bool Site_View => user.HasClaim("Site_View", "true");

        [DA:Required]
        [DA:Display(Name = "Эл.кабинет. Редактировать.")]
        public bool Site_Edit => user.HasClaim("Site_Edit", "true");

        [DA:Required]
        [DA:Display(Name = "Эл.кабинет. Удалять.")]
        public bool Site_Delete => user.HasClaim("Site_Delete", "true");

        [DA:Required]
        [DA:Display(Name = "Эл.кабинет. Создать кабинет.")]
        public bool Site_Create => user.HasClaim("Site_Create", "true");

        [DA:Required]
        [DA:Display(Name = "Эл.кабинет. Добавить в очередь.")]
        public bool Site_AddToTurn => user.HasClaim("Site_AddToTurn", "true");
        #endregion

        #region Очередь
        [DA:Required]
        [DA:Display(Name = "Очередь")]
        public bool Turn_View => user.HasClaim("Turn_View", "true");

        [DA:Required]
        [DA:Display(Name = "Очередь. Создать.")]
        public bool Turn_Create => user.HasClaim("Turn_Create", "true");

        [DA:Required]
        [DA:Display(Name = "Очередь. Редактировать.")]
        public bool Turn_Edit => user.HasClaim("Turn_Edit", "true");

        [DA:Required]
        [DA:Display(Name = "Очередь. Удалять.")]
        public bool Turn_Delete => user.HasClaim("Turn_Delete", "true");

        [DA:Required]
        [DA:Display(Name = "Очередь. Принять документы.")]
        public bool Turn_Admit => user.HasClaim("Turn_Admit", "true");
        #endregion

        #region Принятые
        [DA:Required]
        [DA:Display(Name = "Принятые")]
        public bool Admission_View => user.HasClaim("Admission_View", "true");

        [DA:Required]
        [DA:Display(Name = "Принятые. Редактировать.")]
        public bool Admission_Edit => user.HasClaim("Admission_Edit", "true");

        [DA:Required]
        [DA:Display(Name = "Принятые. Выдать документы.")]
        public bool Admission_Remove => user.HasClaim("Admission_Remove", "true");

        [DA:Required]
        [DA:Display(Name = "Принятые. Зачислять.")]
        public bool Admission_Accept => user.HasClaim("Admission_Accept", "true");
        #endregion

        #region Зачисленные
        [DA:Required]
        [DA:Display(Name = "Зачисленные")]
        public bool Accepted_View => user.HasClaim("Accepted_View", "true");

        [DA:Required]
        [DA:Display(Name = "Зачисленные. Редактировать.")]
        public bool Accepted_Edit => user.HasClaim("Accepted_Edit", "true");

        [DA:Required]
        [DA:Display(Name = "Зачисленные. Выдать документы.")]
        public bool Accepted_Remove => user.HasClaim("Accepted_Remove", "true");

        [DA:Required]
        [DA:Display(Name = "Зачисленные. Перезачислить.")]
        public bool Accepted_Accept => user.HasClaim("Accepted_Accept", "true");
        #endregion

        #region Не зачисленные
        [DA:Required]
        [DA:Display(Name = "Не зачисленные")]
        public bool NotAccepted_View => user.HasClaim("NotAccepted_View", "true");

        [DA:Required]
        [DA:Display(Name = "Не зачисленные. Редактировать.")]
        public bool NotAccepted_Edit => user.HasClaim("NotAccepted_Edit", "true");

        [DA:Required]
        [DA:Display(Name = "Не зачисленные. Выдать документы.")]
        public bool NotAccepted_Remove => user.HasClaim("NotAccepted_Remove", "true");

        [DA:Required]
        [DA:Display(Name = "Не зачисленные. Зачислить.")]
        public bool NotAccepted_Accept => user.HasClaim("NotAccepted_Accept", "true");
        #endregion

        #region Забранные
        [DA:Required]
        [DA:Display(Name = "Забранные")]
        public bool Zabr_View => user.HasClaim("Zabr_View", "true");

        [DA:Required]
        [DA:Display(Name = "Забранные. Удалять.")]
        public bool Zabr_Delete => user.HasClaim("Zabr_Delete", "true");

        [DA:Required]
        [DA:Display(Name = "Забранные. Добавить в очередь.")]
        public bool Zabr_AddToTurn => user.HasClaim("Zabr_AddToTurn", "true");
        #endregion


    }
}
