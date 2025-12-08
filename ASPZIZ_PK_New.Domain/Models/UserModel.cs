using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPZIZ_PK_New.Domain.Models;

public class UserModel
{
    public Guid UserID { get; set; }

    [Display(Name = "Имя для входа в систему")]
    public string Login { get; set; }

    [Display(Name = "Полное имя для печати")]
    public string UserName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Пароль")]
    public string Password { get; set; }

    [Required]
    [Display(Name = "Group")]
    public string Group { get; set; }

    [Display(Name = "Last signed in")]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:d}")]
    public DateTime LastSignedIn { get; set; }

    [Display(Name = "IsOnline")]
    public bool IsOnline { get; set; }

    [Required]
    [Display(Name = "Require password change")]
    public bool RequirePasswordChange { get; set; }

    [Display(Name = "Locked")]
    public bool IsLocked { get; set; }

    public PermissionsModel Permissions { get; set; }

    public PlaceModel Place { get; set; }

    public UserModel()
    {
        this.Permissions = new PermissionsModel();
    }
}