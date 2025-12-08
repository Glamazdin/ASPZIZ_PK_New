using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ASPZIZ_PK_New.Persistence.Entities;

public class ApplicationUser : IdentityUser<Guid>
{

    public string? FullName { get; set; }
    // Navigation properties for all relationships to AspNetUsers
    public virtual ICollection<Abitur> Abiturs { get; set; } = new List<Abitur>();
    
    public virtual ICollection<AbiturRegStepChangeLog> AbiturRegStepChangeLogs { get; set; } = new List<AbiturRegStepChangeLog>();
    
    public virtual ICollection<Accept> AcceptInGroupUsers { get; set; } = new List<Accept>();
    
    public virtual ICollection<Accept> AcceptInSpecialityUsers { get; set; } = new List<Accept>();
    
    //public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; } = new List<AspnetPersonalizationPerUser>();
    
    public virtual ICollection<PermissionUser> PermissionUsers { get; set; } = new List<PermissionUser>();
    
    public virtual ICollection<PlaceUser> PlaceUsers { get; set; } = new List<PlaceUser>();
    
    public virtual ICollection<Register> Registers { get; set; } = new List<Register>();
    
    public virtual Table TableAsTableNavigation { get; set; } 
    
    public virtual ICollection<Table> TableAsDuty { get; set; } = new List<Table>();
    
    public virtual ICollection<TablesLog> TablesLogAsChanger { get; set; } = new List<TablesLog>();
    
    public virtual ICollection<TablesLog> TablesLogAsTable { get; set; } = new List<TablesLog>();


    public virtual ICollection<Place> Places { get; set; } = new List<Place>();

    //



}
