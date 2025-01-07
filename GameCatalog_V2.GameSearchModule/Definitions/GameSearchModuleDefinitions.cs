
using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace GameCatalog_V2.GameSearchModule.Definitions;

public class GameSearchModuleDefinitions : AppDefinition
{
    public override bool Exported => true;

    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IBlazorModule, GameSearchBlazorModule>();
    }
    public override void ConfigureApplication(WebApplication app)
    {
        app.UseStaticFiles();
        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(
           Path.Combine(AppContext.BaseDirectory, "C:\\Users\\Maksat\\source\\repos\\GameCatalog_V2\\GameCatalog_V2.GameSearchModule", "wwwroot")),
            RequestPath = "/GameSearch"
        });
    }
}