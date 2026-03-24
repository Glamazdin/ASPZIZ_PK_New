using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPZIZ_PK_New.Features.Admin.Specialities;

public sealed record GetSpecialitiesList(short? FacultyId) : IRequest<List<SpecialityListModel>>;

public class GetSpecialitiesListHandler(ApplicationDbContext db) : IRequestHandler<GetSpecialitiesList, List<SpecialityListModel>>
{
    public async Task<List<SpecialityListModel>> Handle(GetSpecialitiesList request, CancellationToken cancellationToken=default)
    {
       return  await db.VuzSpecs
            .Include(s => s.ObrVid)
            .Include(s => s.Faclt)
            .Include(s => s.VuzSrok)
            .Include(s => s.Spec)
            .Include(s => s.SpecGroup)
            .AsNoTracking()        
            .Where(s=> !request.FacultyId.HasValue ||s.FacltId==request.FacultyId.Value)
            .ProjectToType<SpecialityListModel>()
            .ToListAsync(cancellationToken);      
    }
}

