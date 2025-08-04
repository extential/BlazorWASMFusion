using BlazorApp2.Client.Pages;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

ClientStartup.ConfigureServices(builder.Services, builder);

await builder.Build().RunAsync();