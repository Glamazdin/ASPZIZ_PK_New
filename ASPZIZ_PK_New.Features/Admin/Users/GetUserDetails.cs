
using ASPZIZ_PK_New.Domain.Enums;
using ASPZIZ_PK_New.Features.Admin.Models;
using ASPZIZ_PK_New.Persistence.Entities;
using ASPZIZ_PK_New.Persistence.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace ASPZIZ_PK_New.Features.Admin.Users;
/// <summary>
/// Получение подробной информации о пользователе
/// </summary>
/// <param name="Id">Идентификатор пользователя</param>
public sealed record GetUserDetails(Guid Id) : IRequest<UserFullModel>
{
}

public class GetUserDetailsHandler(ApplicationDbContext db) : IRequestHandler<GetUserDetails, UserFullModel>
{
    public async Task<UserFullModel> Handle(GetUserDetails request, CancellationToken cancellationToken=default)
    {
        var user = await db.Users
            //.Include(u => u.PermissionUsers)
            //.Include(u=>u.User)
            .Include(u=>u.Place)
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Id.Equals(request.Id));
        if (user == null) return null;

        var model = new UserFullModel(
                                        user.Id, 
                                        user.UserName,                                         
                                        user.FullName, 
                                        user.Place
                                        );

        var claims = db.UserClaims.Where(uc => uc.UserId == user.Id).ToList();
        Type modelType = typeof( UserFullModel );

        foreach(var claim in claims)
        {
            string name = claim.ClaimType;
            var propInfo = modelType.GetProperty(name);
            //if (propInfo == null) continue;
            propInfo.SetValue(model, true);
        }

        //foreach (var permission in user.PermissionUsers)
        //{
        //    string name = Enum.GetName(typeof(PermissionsAspziz), permission.PermissionId);

        //    var propInfo = modelType.GetProperty(name);
        //    //if (propInfo == null) continue;
        //    propInfo.SetValue(model, true);
        //}


        return model;
    }
}
