using ASPZIZ_PK_New.Features.Admin.Models;
using ASPZIZ_PK_New.Persistence.Entities;
using ASPZIZ_PK_New.Persistence.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ASPZIZ_PK_New.Features.Admin.Specialities;

public sealed record CreateOkskSpecCommand(OKSKListModel Model) : IRequest<short>;

public class CreateOkskSpecHandler(ApplicationDbContext db) : IRequestHandler<CreateOkskSpecCommand, short>
{
    public async Task<short> Handle(CreateOkskSpecCommand request, CancellationToken cancellationToken = default)
    {
        var model = request.Model ?? throw new ArgumentNullException(nameof(request.Model));

        if (string.IsNullOrWhiteSpace(model.Name))
            throw new ArgumentException("Name is required", nameof(model.Name));

        // Проверка наличия записи с таким же названием (case-insensitive)
        var exists = await db.OkskSpecs
            .AsNoTracking()
            .AnyAsync(s => s.SpecName.ToUpper() == model.Name.ToUpper(), cancellationToken);

        if (exists)
            throw new InvalidOperationException("Специальность с таким названием уже существует.");

        var entity = new OkskSpec
        {
            SpecName = model.Name,
            SpecCode = model.Code,
            SpecAbbr = model.Abbr,
            SpecKvalif = model.Kvalif
        };

        var ids = await db.OkskSpecs
                      .AsNoTracking()
                      .OrderBy(s => s.SpecId)
                      .Select(s => s.SpecId)
                      .ToListAsync();

        short expected = 1;
        foreach (var id in ids)
        {
            if (id < expected) continue;
            if (id > expected) break;
            // id == expected
            if (expected == short.MaxValue) throw new InvalidOperationException("No free SpecId");
            expected++;
        }
        entity.SpecId = expected;

        db.OkskSpecs.Add(entity);
        await db.SaveChangesAsync(cancellationToken);

        return entity.SpecId;
    }
}