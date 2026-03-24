using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ASPZIZ_PK_New.Persistence.Entities;

public class ApplicationUser : IdentityUser<Guid>
{

    public string? FullName { get; set; }
    public bool IsBlocked { get; set; } = false;
    public DateTime? LastLoginDate { get; set; }
    // Navigation properties for all relationships to AspNetUsers
    public ICollection<Abitur> Abiturs { get; set; } = new List<Abitur>();
    
    public ICollection<AbiturRegStepChangeLog> AbiturRegStepChangeLogs { get; set; } = new List<AbiturRegStepChangeLog>();
    
    public  ICollection<Accept> AcceptInGroupUsers { get; set; } = new List<Accept>();
    
    public  ICollection<Accept> AcceptInSpecialityUsers { get; set; } = new List<Accept>();
    
    //public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; } = new List<AspnetPersonalizationPerUser>();
    
    //public  ICollection<PermissionUser> PermissionUsers { get; set; } = new List<PermissionUser>();
    
   // public virtual ICollection<PlaceUser> PlaceUsers { get; set; } = new List<PlaceUser>();
    
    public  ICollection<Register> Registers { get; set; } = new List<Register>();
    
    public  Table TableAsTableNavigation { get; set; } 
    
    public  ICollection<Table> TableAsDuty { get; set; } = new List<Table>();
    
    public  ICollection<TablesLog> TablesLogAsChanger { get; set; } = new List<TablesLog>();
    
    public  ICollection<TablesLog> TablesLogAsTable { get; set; } = new List<TablesLog>();


    public byte PlaceId { get; set; }    
    public Place Place { get; set; } 

    //



}
