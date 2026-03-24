using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPZIZ_PK_New.Features.Admin.Specialities;

public sealed record GetFacultiesList : IRequest<IEnumerable<FacultyListModel>>;

public class GetFucultiesListHandler(ApplicationDbContext db) : IRequestHandler<GetFacultiesList, IEnumerable<FacultyListModel>>
{
    public async Task<IEnumerable<FacultyListModel>> Handle(GetFacultiesList request, CancellationToken cancellationToken = default)
    {
        return await db.VuzFaclts
            .AsNoTracking()
            .ProjectToType<FacultyListModel>()
            .ToListAsync();
    }
}

