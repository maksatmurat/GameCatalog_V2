

using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace GameCatalog_V2.GameSearchModule.Definitions;

public class GameSearchBlazorModule : BlazorModule
{
    public override int OrderIndex => 5;
    public override string Title => "Game Search";

    public override string Description => "Game Search Page";

    public override string Route => "/gamesearch";
    public override NavLinkMatch Match => NavLinkMatch.Prefix;
}