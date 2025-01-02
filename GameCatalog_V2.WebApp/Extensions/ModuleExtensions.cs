using Calabonga.Blazor.AppDefinitions;
using Microsoft.AspNetCore.Components.Routing;

namespace GameCatalog_V2.WebApp.Extensions;

public static class ModuleExtensions
{
    public static IEnumerable<AssemblyNavLink> AsNavLinks(this IEnumerable<BlazorAppDefinition> source)
    {
        return source.SelectMany(x => x.Modules).OrderBy(y => y.OrderIndex).Select(x => new AssemblyNavLink(x.Route, x.Title, x.Match));
    }
}

public record AssemblyNavLink(string Route, string Title, NavLinkMatch Match = NavLinkMatch.Prefix);
