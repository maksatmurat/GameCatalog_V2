using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace GameCatalog_V2.MainModule.Definitions;

public class MainModuleDefinitions : AppDefinition
{
    public override bool Exported => true;

    public override void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IBlazorModule, MainBlazorModule>();
    }
    public override void ConfigureApplication(WebApplication app)
    {
        app.UseStaticFiles();
        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(
           Path.Combine(AppContext.BaseDirectory, "C:\\Users\\Maksat\\source\\repos\\GameCatalog_V2\\GameCatalog_V2.MainModule", "wwwroot")),
            RequestPath = "/MainModule"
        });
    }
}
