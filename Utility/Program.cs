// See https://aka.ms/new-console-template for more information
using ASPZIZ_PK_New.Persistence.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

Console.WriteLine("Hello, World!");

var options = new DbContextOptionsBuilder<ApplicationDbContext>()
    .UseSqlServer("Server=.\\SQLEXPRESS;Database=Test_ASPZIZ_PK;Integrated Security=True;Trust Server Certificate=True;")
    .Options;

var options1 = new DbContextOptionsBuilder<ApplicationDbContext>()
    .UseSqlServer("Server=.\\SQLEXPRESS;Database=CLEAR_ASPZIZ_PK;Integrated Security=True;Trust Server Certificate=True;")
    .Options;

var oldConnStr = "Server=.\\SQLEXPRESS;Database=CLEAR_ASPZIZ_PK;Integrated Security=True;Trust Server Certificate=True;";

using var db = new ApplicationDbContext(options);


//var debug = db.Users.Include(u => u.PermissionUsers).First(u => u.NormalizedUserName.Equals("DEBUG"));
//debug.PermissionUsers.Add(new PermissionUser
//{
//    PartId = 4,
//    PermissionId = (byte)PermissionsAspziz.Adm_Users_User_View
//});
//debug.PermissionUsers.Add(new PermissionUser
//{
//    PartId = 4,
//    PermissionId = (byte)PermissionsAspziz.Adm_Users_View
//});
//debug.PermissionUsers.Add(new PermissionUser
//{
//    PartId = 4,
//    PermissionId = (byte)PermissionsAspziz.Adm
//});

//await db.SaveChangesAsync();



//var users = db.Users.Include(u => u.Place).ToList();
//var places = await db.Places.ToListAsync();

//using var conn = new SqlConnection(oldConnStr);
//var query = """
//      SELECT  
//        [placeId]
//        ,[userId]
//    FROM [CLEAR_ASPZIZ_PK].[dbo].[Place_User]
//    """;

//using var cmd = new SqlCommand(query,conn);
//await conn.OpenAsync();
//using var reader = await cmd.ExecuteReaderAsync();
//while (await reader.ReadAsync())
//{
//    var placeId = reader.GetByte("placeId");
//    var userId = reader.GetGuid("userId");
//    var place = places.First(p=>p.PlaceId== placeId);
//    var user = users.First(u=>u.Id == userId);
//    user.Place = place;

//}
//await db.SaveChangesAsync();
//await conn.CloseAsync();





//foreach (var user in users)
//{
//    var places = user.Places
//        .Join(db.Places,
//            pu => pu.PlaceId,
//            p => p.PlaceId,
//            (pu, p) => p).ToList();

//    places.ForEach(p => user.Places.Add(p));
//}

//await db.SaveChangesAsync();