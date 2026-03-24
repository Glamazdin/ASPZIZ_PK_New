using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPZIZ_PK_New.Features.Shared
{
    public sealed record GetPlaces: IRequest<List<Place>>
    {
    }

    public class GetPlacesHAndler(ApplicationDbContext db) : IRequestHandler<GetPlaces, List<Place>>
    {
        public async Task<List<Place>> Handle(GetPlaces request, CancellationToken cancellationToken=default)
        {
            return await db.Places.ToListAsync(cancellationToken);
        }
    }
}
