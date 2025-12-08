using ASPZIZ_PK_New.Domain.Models;
using ASPZIZ_PK_New.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPZIZ_PK_New.Features.Admin.Users;

public sealed record GetUsersList : IRequest<IEnumerable<UserModel>>
{
}

public class GetUsersListHandler(ApplicationDbContext db) : IRequestHandler<GetUsersList, IEnumerable<UserModel>>{
    public async Task<IEnumerable<UserModel>> Handle(GetUsersList request, CancellationToken cancellationToken)
    {
        //var users = await db.Users.Include(u=>u.PermissionUsers).Include(u=>).ToListAsync();

        throw new NotImplementedException();
    }
}