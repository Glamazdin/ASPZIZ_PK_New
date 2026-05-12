using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ASPZIZ_PK_New.Features.Abiturs.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Features.Abiturs;

public sealed record GetAbitursList() : IRequest<List<AbiturListModel>>;

public class GetAbitursListHandler(ApplicationDbContext db) : IRequestHandler<GetAbitursList, List<AbiturListModel>>
{
    public async Task<List<AbiturListModel>> Handle(GetAbitursList request, CancellationToken cancellationToken = default)
    {
        // increase timeout temporarily
        db.Database.SetCommandTimeout(TimeSpan.FromSeconds(120));

        // base query; split queries prevents one huge join SQL
        var query = db.Abiturs
            .AsNoTracking()
            .AsSplitQuery();

        // Project only the fields we need. We pick a representative AbiturZayvl (first by Prior)
        var result = await query
            .Select(a => new AbiturListModel
            {
                AbiturId = a.AbiturId,
                PersonalNumber = a.AbtCode,
                FullName = a.Fam + " " + a.Im + (string.IsNullOrWhiteSpace(a.Otch) ? "" : " " + a.Otch),

                // pick first application (representative)
                // EF Core can translate OrderBy().FirstOrDefault() inside the projection
                // if it fails, replace with separate query or join
                Oplata = a.AbiturZayvls
                            .OrderBy(z => z.Prior)
                            .Select(z => z.VuzSpec != null ? (z.VuzSpec.OplataB ? "Платное" : "Бюджет") : "")
                            .FirstOrDefault(),
                Srok = a.AbiturZayvls
                            .OrderBy(z => z.Prior)
                            .Select(z => z.VuzSpec != null ? z.VuzSpec.VuzSrok.SrokName : "")
                            .FirstOrDefault(),
                ObrForma = a.AbiturZayvls
                            .OrderBy(z => z.Prior)
                            .Select(z => z.VuzSpec != null ? z.VuzSpec.ObrVid.ObrVidName : "")
                            .FirstOrDefault(),
                FacultyAbbr = a.AbiturZayvls
                            .OrderBy(z => z.Prior)
                            .Select(z => z.VuzSpec != null ? z.VuzSpec.Faclt.FacltAbbrRu : "")
                            .FirstOrDefault(),
                SpecAbbr = a.AbiturZayvls
                            .OrderBy(z => z.Prior)
                            .Select(z => z.VuzSpec != null ? z.VuzSpec.Spec.SpecAbbr : "")
                            .FirstOrDefault(),

                ByCompetition = a.AbiturZayvls
                            .OrderBy(z => z.Prior)
                            .Select(z => (int?)z.ApplicationNumber ?? 0)
                            .FirstOrDefault() > 0,

                AcceptedBy = a.Accepts
                            .OrderByDescending(ac => ac.AcceptInSpecialityDateTime)
                            .Select(ac => ac.AcceptInSpecialityUser != null ? ac.AcceptInSpecialityUser.FullName : "")
                            .FirstOrDefault()
            })
            // optional: add pagination here: .Skip(pageIndex * pageSize).Take(pageSize)
            .ToListAsync(cancellationToken);

        return result;
    }
}