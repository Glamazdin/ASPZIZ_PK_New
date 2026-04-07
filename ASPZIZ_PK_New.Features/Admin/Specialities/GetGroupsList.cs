using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ASPZIZ_PK_New.Features.Admin.Models;
using System;
using ASPZIZ_PK_New.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using static ASPZIZ_PK_New.Features.Admin.Models.VuzSpecCreateModel;

namespace ASPZIZ_PK_New.Features.Admin.Specialities;

public sealed record GetGroupsList() : IRequest<List<GroupOfSpecialityModel>>;

public class GetGroupsListHandler(ApplicationDbContext db) : IRequestHandler<GetGroupsList, List<GroupOfSpecialityModel>>
{
    public async Task<List<GroupOfSpecialityModel>> Handle(GetGroupsList request, CancellationToken cancellationToken = default)
    {
        return await db.GroupOfSpecialities
            .AsNoTracking()
            .OrderBy(g => g.GroupName)
            .Select(g => new GroupOfSpecialityModel
            {
                GroupId = g.GroupId,
                GroupName = g.GroupName
            })
            .ToListAsync(cancellationToken);
    }
}

