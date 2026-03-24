using ASPZIZ_PK_New.Persistence.Entities;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Claims;


namespace ASPZIZ_PK_New.UI.Components.Account
{
    // This is a server-side AuthenticationStateProvider that revalidates the security stamp for the connected user
    // every 30 minutes an interactive circuit is connected.
    internal sealed class IdentityRevalidatingAuthenticationStateProvider(
            ILoggerFactory loggerFactory,
            IServiceScopeFactory scopeFactory,
            IOptions<IdentityOptions> options,
            IHttpContextAccessor httpContextAccessor,
            ApplicationDbContext db)
        : RevalidatingServerAuthenticationStateProvider(loggerFactory)
    {
        protected override TimeSpan RevalidationInterval => TimeSpan.FromMinutes(30);

        

        protected override async Task<bool> ValidateAuthenticationStateAsync(
            AuthenticationState authenticationState, CancellationToken cancellationToken)
        {
            // Get the user manager from a new scope to ensure it fetches fresh data
            await using var scope = scopeFactory.CreateAsyncScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            return await ValidateSecurityStampAsync(userManager, authenticationState.User);
        }

        private async Task<bool> ValidateSecurityStampAsync(UserManager<ApplicationUser> userManager, ClaimsPrincipal principal)
        {
            var user = await userManager.GetUserAsync(principal);
            if (user is null)
            {
                return false;
            }
            else if (!userManager.SupportsUserSecurityStamp)
            {
                return true;
            }
            else
            {
                var principalStamp = principal.FindFirstValue(options.Value.ClaimsIdentity.SecurityStampClaimType);
                var userStamp = await userManager.GetSecurityStampAsync(user);
                return principalStamp == userStamp;
            }
        }

        //public async Task SetClaimsAsync()
        //{

        //    var httpContext = httpContextAccessor.HttpContext;
        //    if (httpContext == null)
        //        return; 

        //    var user = httpContext.User;
        //    if (!user.Identity.IsAuthenticated)
        //        return; 

        //    // Получаем ID пользователя
        //    var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        //    if (string.IsNullOrEmpty(userId))
        //        return; 

        //    // Загружаем связанную сущность из БД
        //    var dbUser = await db.Users
        //        .Include(u => u.PermissionUsers) // предположим, навигационное свойство Profile
        //        .FirstOrDefaultAsync(u => u.Id == Guid.Parse(userId));

        //    if (dbUser == null)
        //        return; 

        //    // Создаём новый ClaimsPrincipal с расширенными claims
        //    var identity = new ClaimsIdentity();

        //    // Копируем основные claims
        //    identity.AddClaims(user.Claims);

        //    // Добавляем кастомные claims из связанной таблицы
        //    if (dbUser.PermissionUsers != null)
        //    {
        //        // получить все значения перечисления PermissionsAspziz
        //        var permissionValues = Enum.GetValues(typeof(PermissionsAspziz))
        //            .Cast<PermissionsAspziz>()
        //            .Select(v => (byte)v)
        //            .ToArray();

        //        // добавить Claim для кажного разрешения
        //        foreach (var item in permissionValues)
        //        {
        //            var value = dbUser.PermissionUsers.Any(p => p.PermissionId == item);
        //            var name = Enum.GetName(typeof(PermissionsAspziz), item);
        //            identity.AddClaim(new Claim(name, value.ToString()));
        //        }
        //        // Можно добавить и другие данные: Email, роль из профиля и т.д.
        //    }

        //    var newPrincipal = new ClaimsPrincipal(identity);
        //    var authState = Task.FromResult(new AuthenticationState(newPrincipal));
        //    NotifyAuthenticationStateChanged(authState);
        //}
    }
}
