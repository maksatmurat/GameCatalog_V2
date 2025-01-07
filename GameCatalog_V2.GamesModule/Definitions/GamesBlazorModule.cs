using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace GameCatalog_V2.GamesModule.Definitions;

public class GamesBlazorModule : BlazorModule
{
    public override int OrderIndex => 2;
    public override string Title => "Games";

    public override string Description => "Games Page";

    public override string Route => "/games";
    public override NavLinkMatch Match => NavLinkMatch.Prefix;
}