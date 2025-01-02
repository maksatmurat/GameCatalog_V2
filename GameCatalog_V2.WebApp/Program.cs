using Calabonga.Blazor.AppDefinitions;
using GameCatalog_V2.WebApp.Components;

var builder = WebApplication.CreateBuilder(args);

builder.AddBlazorModulesDefinitions("Modules", typeof(App));

var app = builder.Build();

app.UseDefinitions();

app.Run();
