
using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace GameCatalog_V2.GenresModule.Definitions;

public class GenresBlazorModule: BlazorModule
{
    public override int OrderIndex => 3;
    public override string Title => "Genres";

    public override string Description => "Genres Page";

    public override string Route => "/genres";
    public override NavLinkMatch Match => NavLinkMatch.Prefix;
}
