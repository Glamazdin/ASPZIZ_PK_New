using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ASPZIZ_PK_New.Features.Admin.Models;

public class SpecialityListModel
{
    // Id специальности
    public short VuzSpecId { get; set; }   

    // Id факультета
    public short FacltId { get; set; }
    //public VuzFaclt Faclt { get; set; }
    public string FacultyName { get; set; }
    //public OkskSpec Spec { get; set; }

    public string SpecialityName { get; set; }

    // Платное / Бюджет
    public bool OplataB { get; set; }
    public string Oplata { get => OplataB ? "Платное" : "Бюджет"; }

    // Вид образование
    public byte ObrVidId { get; set; }
    //public ObrVid ObrVid { get; set; }
    public string ObrVidName { get; set; }

    // форма обучения
    public byte ObrFormaId { get; set; }
    public string ObrFormaName { get; set; }


    // Срок обучения
    public byte VuzSrokId { get; set; }

    //public VuzSrok VuzSrok { get; set; }
    public string Srok { get; set; }


    // Целевое
    public bool CelevB { get; set; }

    // План набора
    public short KolvoMest { get; set; }
        

    // Группа специальностей
    public byte SpecGroupId { get; set; }
    
    //public GroupOfSpeciality SpecGroup { get; set; }
    
    public string GroupName { get; set; }

    public string? SpecCode { get; set; }
    
    
   
     
              
    


}
