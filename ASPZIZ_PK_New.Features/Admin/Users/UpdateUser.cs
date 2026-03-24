using ASPZIZ_PK_New.Domain.Enums;
using ASPZIZ_PK_New.Features.Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPZIZ_PK_New.Features.Admin.Users
{
    public sealed record UpdateUser(UserFullModel user) : IRequest;

    public class UpdateUserHandler(UserManager<ApplicationUser> userManager, ApplicationDbContext db) : IRequestHandler<UpdateUser>
    {
        public async Task Handle(UpdateUser request, CancellationToken cancellationToken)
        {
            ApplicationUser user;
            if (request.user.Id != Guid.Empty)
                user = await userManager.FindByNameAsync(request.user.Login);
            else
            {
                user = new ApplicationUser();
                await userManager.CreateAsync(user);
            }
                

                // изменить login (name и email)            

            await userManager.SetUserNameAsync(user, request.user.Login);
            await userManager.SetEmailAsync(user, request.user.Login);

            // изменить пароль

            if (!String.IsNullOrEmpty(request.user.Password))
            {
                var token = await userManager.GeneratePasswordResetTokenAsync(user);
                await userManager.ResetPasswordAsync(user, token, request.user.Password);
            }
         
            // изменить полное имя
            user.FullName = request.user.FullName;
            // изменить место
            user.PlaceId = request.user.Place.PlaceId;

            db.Entry(user).State = EntityState.Modified;
            await db.SaveChangesAsync();

            // изменить разрешения

            // удалить старые разрешения
            await db.PermissionUsers.Where(p => p.UserId == user.Id).ExecuteDeleteAsync();

            // найти все свойства типа bool
            var userModelType = typeof(UserFullModel);
            var boolProps = userModelType
                .GetProperties()
                .Where(p => p.PropertyType == typeof(bool))
                .ToList();

            // добавить разрешения
            var permList = new List<PermissionUser>();
            foreach (var perm in boolProps)
            {
                if (Enum.TryParse<PermissionsAspziz>(perm.Name, out PermissionsAspziz permission))
                {
                    if((bool)perm.GetValue(request.user))
                    {
                        permList.Add(new PermissionUser { UserId = user.Id, PermissionId = ((byte)permission) });
                    }
                }      
            }
            if (permList.Count != 0)
            {
                await db.PermissionUsers.AddRangeAsync(permList);
                await db.SaveChangesAsync();
            }
        }
    }

}
