using Calabonga.Blazor.AppDefinitions;
using DataAccess;
using GameCatalog_V2.DataAccess.Repository;
using GameCatalog_V2.WebApp.Components;
using Microsoft.EntityFrameworkCore;

namespace GameCatalog_V2.WebApp.Definitions;

public class CommonDefinition : AppDefinition
{
    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
        builder.Services.AddScoped<IRepository, SqliteGameRepository>();
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite("Data Source=C:\\Users\\Maksat\\source\\repos\\GameCatalog_V2\\GameCatalog_V2.DataAccess\\Database\\GameIndustryBase.db"));

    }
    public override void ConfigureApplication(WebApplication app)
    {
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseStaticFiles();
        app.UseHttpsRedirection();

        app.UseAntiforgery();

        app.MapStaticAssets();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode()
            .AddAdditionalAssemblies(ModuleDefinitions.Instance.Assemblies.ToArray());

    }
}
