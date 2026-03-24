using ASPZIZ_PK_New.Features;
using ASPZIZ_PK_New.Persistence.Entities;
using ASPZIZ_PK_New.UI.Components;
using ASPZIZ_PK_New.UI.Components.Account;
using ASPZIZ_PK_New.UI.Helpers;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddPooledDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;

        options.Stores.SchemaVersion = IdentitySchemaVersions.Version3;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddAuthorization(opt => {
    opt.AddPolicy("CanViewUsers", p => p.RequireClaim("Adm_Users_User_View"));
    opt.AddPolicy("CanViewSpecialities", p => p.RequireClaim("Adm_Specialities_View"));
});

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
builder.Services.AddHttpContextAccessor();

// Add user services
builder.Services.AddFeatures();

// заменяем стандартный UserClaimsPrincipalFactory на кастомный
builder.Services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>,
                          ApplicationUserClaimsPrincipalFactory>();

// заменяем стандартный SignInManager на кастомный
builder.Services.AddScoped<SignInManager<ApplicationUser>, CustomSignInManager>();
builder.Services.AddRadzenComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

await RegisterAdmin(app);

app.Run();

async Task RegisterAdmin(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    using var um = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    using var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    var temp = await um.FindByEmailAsync("debug");
    if (temp != null) return;



    var user = new ApplicationUser()
    {
        UserName = "debug",
        FullName = "debug",
        NormalizedUserName = "debug",
        Email = "debug",
        NormalizedEmail = "debug",
        EmailConfirmed = true
    };
    var result = await um.CreateAsync(user, "123456");

}
