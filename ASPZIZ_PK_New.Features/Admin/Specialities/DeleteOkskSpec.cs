using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ASPZIZ_PK_New.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Features.Admin.Specialities;

public sealed record DeleteOkskSpecsCommand(short SpecId) : IRequest<int>;

public class DeleteOkskSpecsHandler(ApplicationDbContext db) : IRequestHandler<DeleteOkskSpecsCommand, int>
{
    public async Task<int> Handle(DeleteOkskSpecsCommand request, CancellationToken cancellationToken = default)
    {
        //var ids = request.SpecIds?.Where(id => id > 0).Distinct().ToList() ?? new List<short>();
        if (!(request.SpecId>0)) return 0;

        // Use transaction to ensure consistency
        await using var tx = await db.Database.BeginTransactionAsync(cancellationToken);
        try
        {
            // 1. Find VuzSpec ids that reference these OKSK specs
            var vuzSpecIds = await db.VuzSpecs
                .AsNoTracking()
                .Where(v => v.SpecId==request.SpecId)
                .Select(v => v.VuzSpecId)
                .ToListAsync(cancellationToken);

            // 2. Find OkskSpecSpecialization ids for these specs
            var specSpecializationIds = await db.OkskSpecSpecializations
                .AsNoTracking()
                .Where(s => s.SpecId== request.SpecId)
                .Select(s => s.Id)
                .ToListAsync(cancellationToken);

            // 3. Delete VuzSpecializations referencing either found VuzSpec or SpecSpecialization
            var vuzSpecializations = await db.VuzSpecializations
                .Where(vs => vuzSpecIds.Contains(vs.VuzSpecId) || specSpecializationIds.Contains(vs.SpecSpecializationId))
                .ToListAsync(cancellationToken);
            if (vuzSpecializations.Any())
                db.VuzSpecializations.RemoveRange(vuzSpecializations);

            await db.SaveChangesAsync(cancellationToken);

            // 4. Delete VuzSpecial (VuzSpec) entries referencing the OKSK spec
            var vuzSpecs = await db.VuzSpecs
                .Where(v => v.SpecId == request.SpecId)
                .ToListAsync(cancellationToken);
            if (vuzSpecs.Any())
                db.VuzSpecs.RemoveRange(vuzSpecs);

            await db.SaveChangesAsync(cancellationToken);

            // 5. Delete OkskSpecSpecialization for these specs
            var okskSpecSpecializations = await db.OkskSpecSpecializations
                .Where(s => s.SpecId== request.SpecId)
                .ToListAsync(cancellationToken);
            if (okskSpecSpecializations.Any())
                db.OkskSpecSpecializations.RemoveRange(okskSpecSpecializations);

            await db.SaveChangesAsync(cancellationToken);

            // 6. Finally delete OkskSpec entries
            var okskSpecs = await db.OkskSpecs.FindAsync(request.SpecId);
                
            if (okskSpecs!=null)
                db.OkskSpecs.Remove(okskSpecs);

            await db.SaveChangesAsync(cancellationToken);

            await tx.CommitAsync(cancellationToken);

            return 1;
        }
        catch
        {
            await tx.RollbackAsync(cancellationToken);
            throw;
        }
    }
}