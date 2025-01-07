using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace GameCatalog_V2.DeveloperModule.Definitions;

public class DeveloperBlazorModule : BlazorModule
{
    public override int OrderIndex => 2;
    public override string Title => "Developer";

    public override string Description => "Developer Page";

    public override string Route => "/studio";
    public override NavLinkMatch Match => NavLinkMatch.Prefix;
}