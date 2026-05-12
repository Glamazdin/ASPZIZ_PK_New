using System;

namespace ASPZIZ_PK_New.Features.Abiturs.Models;

public class AbiturListModel
{
    public Guid AbiturId { get; set; }

    // Личный номер
    public string PersonalNumber { get; set; } = string.Empty;

    // ФИО
    public string FullName { get; set; } = string.Empty;

    // Платное / Бюджет
    public string Oplata { get; set; } = string.Empty;

    // Срок обучения
    public string Srok { get; set; } = string.Empty;

    // Legacy boolean (kept for compatibility)
    public bool ByCompetition { get; set; }

    // Explicit competition status: "По конкурсу", "Вне конкурса", "Без экзаменов", "Не указано"
    public string CompetitionStatus { get; set; } = string.Empty;

    // Форма обучения
    public string ObrForma { get; set; } = string.Empty;

    // Факультет (сокр.)
    public string FacultyAbbr { get; set; } = string.Empty;

    // Специальность (сокр.)
    public string SpecAbbr { get; set; } = string.Empty;

    // Кто принял
    public string AcceptedBy { get; set; } = string.Empty;
}