using Calabonga.Blazor.AppDefinitions;
using GameCatalog_V2.Core.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace GameCatalog_V2.GamesModule.Definitions;

public class GamesModuleDefinitions : AppDefinition
{
    public override bool Exported => true;

    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IBlazorModule, GamesBlazorModule>();
        builder.Services.AddScoped<IRepository,MockGamesRepository>();
    }
    public override void ConfigureApplication(WebApplication app)
    {
        app.UseStaticFiles();
        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(
           Path.Combine(AppContext.BaseDirectory, "C:\\Users\\Maksat\\source\\repos\\GameCatalog_V2\\GameCatalog_V2.GamesModule", "wwwroot")),
            RequestPath = "/Games"
        });
    }
}