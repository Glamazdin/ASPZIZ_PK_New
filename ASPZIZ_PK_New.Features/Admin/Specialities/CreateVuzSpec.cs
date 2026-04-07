using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using ASPZIZ_PK_New.Features.Admin.Models;
using ASPZIZ_PK_New.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Features.Admin.Specialities;

public sealed record CreateVuzSpecCommand(VuzSpecCreateModel Model) : IRequest<short>;

public class CreateVuzSpecHandler(ApplicationDbContext db) : IRequestHandler<CreateVuzSpecCommand, short>
{
    public async Task<short> Handle(CreateVuzSpecCommand request, CancellationToken cancellationToken = default)
    {
        var model = request.Model ?? throw new ArgumentNullException(nameof(request.Model));

        if (model.FacltId == 0) throw new ArgumentException("Faculty is required", nameof(model.FacltId));
        if (model.SpecId == 0) throw new ArgumentException("Spec is required", nameof(model.SpecId));

        // duplicate check for same faculty+spec
        var exists = await db.VuzSpecs
            .AsNoTracking()
            .AnyAsync(v => v.FacltId == model.FacltId && v.SpecId == model.SpecId, cancellationToken);

        if (exists)
            throw new InvalidOperationException("Специальность с таким OKSK уже добавлена на этот факультет.");

        var entity = new VuzSpec
        {
            // do not set VuzSpecId yet
            VuzId = 1,
            FacltId = model.FacltId,
            SpecId = model.SpecId,
            OplataB = model.OplataB,
            ObrVidId = 1,
            VuzSrokId = 1,
            CelevB = model.CelevB,
            KolvoMest = model.KolvoMest,
            SpecGroupId = model.SpecGroupId,
            SpecCode = null,
            StatSpecGroupId = 0
        };

        // compute base from group (high digits)
        var group = (byte)(model.SpecGroupId)*100;

        // iterate suffix 00..99 to find free id
        for (int suffix = 0; suffix < 100; suffix++)
        {
            short candidate = (short)(group + suffix);
            if (candidate <= 0) continue; // skip 0 if you reserve it

            // quick existence check
            var idExists = await db.VuzSpecs
                .AsNoTracking()
                .AnyAsync(v => v.VuzSpecId == candidate, cancellationToken);

            if (idExists) continue;

            // attempt to persist with this candidate (handle race by catching DbUpdateException)
            entity.VuzSpecId = candidate;
            db.VuzSpecs.Add(entity);
            try
            {
                await db.SaveChangesAsync(cancellationToken);
                return entity.VuzSpecId;
            }
            catch (DbUpdateException)
            {
                // conflict (someone else inserted the same id) — detach and try next candidate
                db.Entry(entity).State = EntityState.Detached;
                continue;
            }
        }

        throw new InvalidOperationException($"No free VuzSpecId found for group {group}. All slots 00..99 are taken.");
    }
}

class SpecsComparer : IEqualityComparer<VuzSpec>
{
    public bool Equals(VuzSpec? x, VuzSpec? y)
    {
        return x.FacltId.Equals(y.FacltId)
            && x.CelevB.Equals(y.CelevB)
            && x.MilitaryB.Equals(y.MilitaryB)
            && x.OplataB.Equals(y.OplataB)
            && x.SpecGroupId.Equals(y.SpecGroupId)
            && x.SpecId.Equals(y.SpecId);
    }

    public int GetHashCode([DisallowNull] VuzSpec obj)
    {
        return obj.FacltId.GetHashCode()
            +obj.CelevB.GetHashCode()
            +obj.MilitaryB.GetHashCode()
            +obj.OplataB.GetHashCode()
            +obj.SpecGroupId.GetHashCode()
            +obj.SpecId.GetHashCode();
    }
}