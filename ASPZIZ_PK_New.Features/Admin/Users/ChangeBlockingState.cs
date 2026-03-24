using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ASPZIZ_PK_New.Features.Admin.Users;

public sealed record ChangeBlockingState(Guid UserId, bool newValue) : IRequest;

public class ChangeBlockingStateHAndler(ApplicationDbContext db) : IRequestHandler<ChangeBlockingState>
{
    public async Task Handle(ChangeBlockingState request, CancellationToken cancellationToken)
    {
        await db.Users.Where(u => u.Id == request.UserId)
            .ExecuteUpdateAsync(u =>
                    u.SetProperty(p => p.IsBlocked, request.newValue));            
    }
}

