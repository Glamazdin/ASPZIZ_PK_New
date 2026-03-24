using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPZIZ_PK_New.Features.Admin.Specialities;

public sealed record GetOKSKList : IRequest<IEnumerable<OKSKModel>>;

public class GetOKSKListHandler(ApplicationDbContext db) : IRequestHandler<GetOKSKList, IEnumerable<OKSKModel>>
{
    public async Task<IEnumerable<OKSKModel>> Handle(GetOKSKList request, CancellationToken cancellationToken = default)
    {
        return await db.OkskSpecs
            .Include(sp => sp.VuzSpecs)
            .AsNoTracking()
            .ProjectToType<OKSKModel>()
            .ToListAsync();
    }
}


