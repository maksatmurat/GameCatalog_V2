
using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace GameCatalog_V2.MainModule.Definitions;

public class MainBlazorModule : BlazorModule
{
    public override int OrderIndex => 1;
    public override string Title => "Home";

    public override string Description => "Home Page";

    public override string Route => "/";
    public override NavLinkMatch Match => NavLinkMatch.All;
}
