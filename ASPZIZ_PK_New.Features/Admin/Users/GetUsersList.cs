using ASPZIZ_PK_New.Domain.Models;
using ASPZIZ_PK_New.Features.Admin.Models;
using ASPZIZ_PK_New.Persistence.Data;
using ASPZIZ_PK_New.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Mapster;

namespace ASPZIZ_PK_New.Features.Admin.Users;
/// <summary>
/// Получение списка пользователей
/// </summary>
public sealed record GetUsersList : IRequest<IEnumerable<UserListModel>>
{
}

public class GetUsersListHandler(ApplicationDbContext db) : IRequestHandler<GetUsersList, IEnumerable<UserListModel>>{
    public async Task<IEnumerable<UserListModel>> Handle(GetUsersList request, CancellationToken cancellationToken=default)
    {
        var users = db.Users
            .Include(u => u.Place)
            .AsNoTracking();
            //.ToListAsync();

        //var model = users
        //    .Select(u => new UserListModel(u.Id,u.UserName, u.FullName, u.IsBlocked, u.LastLoginDate, u.Place?.PlaceName))
        //    .ToList();

        var model = await users.ProjectToType<UserListModel>()
           //.Select(u => new UserListModel(u.Id, u.UserName, u.FullName, u.IsBlocked, u.LastLoginDate, u.Place?.PlaceName))
           .ToListAsync();

        return model;
    }
}
