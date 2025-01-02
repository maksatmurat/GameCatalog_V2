using Calabonga.Blazor.AppDefinitions;
using System.Reflection;

namespace GameCatalog_V2.WebApp.Components;

public partial class Routes
{
    public IEnumerable<Assembly> Modules => ModuleDefinitions.Instance.Assemblies;

}
