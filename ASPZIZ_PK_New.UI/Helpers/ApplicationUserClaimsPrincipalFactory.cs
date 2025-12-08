using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace ASPZIZ_PK_New.UI.Helpers;

public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser>
{
    private readonly ApplicationDbContext _dbContext;

    public ApplicationUserClaimsPrincipalFactory(
        UserManager<ApplicationUser> userManager,
        IOptions<IdentityOptions> optionsAccessor,
        ApplicationDbContext dbContext)
        : base(userManager, optionsAccessor)
    {
        _dbContext = dbContext;
    }

    public override async Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
    {
        var principal = await base.CreateAsync(user);
        var identity = (ClaimsIdentity)principal.Identity!;

        // Загружаем связанные разрешения
        var dbUser = await _dbContext.Users
            .Include(u => u.PermissionUsers)
            .FirstOrDefaultAsync(u => u.Id == user.Id);

        if (dbUser?.PermissionUsers != null)
        {
            var permissionValues = Enum.GetValues(typeof(PermissionsAspziz))
                .Cast<PermissionsAspziz>()
                .ToArray();

            foreach (var permission in permissionValues)
            {
                var hasPermission = dbUser.PermissionUsers.Any(p => p.PermissionId == (byte)permission);
                var name = Enum.GetName(typeof(PermissionsAspziz), permission);
                if (hasPermission && name != null)
                {
                    // Удаляем старый claim (на случай повторного вызова)
                    //identity.RemoveClaim(identity.FindFirst(name));
                    // Добавляем новый
                    identity.AddClaim(new Claim(name, "true"));
                }
            }

        }

        return principal;
    }
}
