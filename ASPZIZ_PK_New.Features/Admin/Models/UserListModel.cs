namespace ASPZIZ_PK_New.Features.Admin.Models;

public class UserListModel
{
    public UserListModel()
    {
        
    }
    public UserListModel(Guid Id, string Login, string FullName, bool IsBlocked, DateTime? LastLoginDate, string Place = "")
    {
        this.Id = Id;
        this.Login = Login;
        this.FullName = FullName;
        this.IsBlocked = IsBlocked;
        this.LastLoginDate = LastLoginDate;
        this.Place = Place;
    }
    public Guid Id { get; set; }
    public string Login { get; set; }
    public string FullName { get; set; }
    public bool IsBlocked { get; set; } = false;
    public DateTime? LastLoginDate { get; set; }
    public string Place { get; set; }=string.Empty;
}