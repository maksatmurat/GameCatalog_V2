using Calabonga.Blazor.AppDefinitions;
using GameCatalog_V2.DataAccess.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Tewr.Blazor.FileReader;

namespace GameCatalog_V2.DeveloperModule.Definitions;

public class DeveloperModuleDefinitions : AppDefinition
{
    public override bool Exported => true;

    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IBlazorModule, DeveloperBlazorModule>();
        builder.Services.AddFileReaderService(options=>options.InitializeOnFirstCall=true);
        builder.Services.AddScoped<IRepository, SqliteGameRepository>();

    }
    public override void ConfigureApplication(WebApplication app)
    {
        app.UseStaticFiles();
        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(
           Path.Combine(AppContext.BaseDirectory, "C:\\Users\\Maksat\\source\\repos\\GameCatalog_V2\\GameCatalog_V2.DeveloperModule", "wwwroot")),
            RequestPath = "/Developer"
        });
    }
}