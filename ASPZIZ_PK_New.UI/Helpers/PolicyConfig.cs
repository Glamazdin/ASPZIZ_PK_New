

namespace ASPZIZ_PK_New.UI.Helpers;

public static class PolicyConfig
{
    public static void Configure(IServiceCollection services)
    {
        services.AddAuthorization(opt =>
        {
            opt.AddPolicy("CanViewUsers", p => p.RequireAssertion(c => c.User.Adm && c.User.Adm_Users_View));
        });
    }
}
