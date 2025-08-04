using System.Diagnostics.CodeAnalysis;
using ActualLab.Fusion;
using ActualLab.Fusion.Blazor;
using ActualLab.Fusion.Extensions;
using ActualLab.Fusion.UI;
using ClassLibrary1.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp2.Client.Pages;

[UnconditionalSuppressMessage("Trimming", "IL2026:RequiresUnreferencedCodeAttribute", Justification = "Fine here")]
public static class ClientStartup
{
    public static void ConfigureServices(IServiceCollection services, WebAssemblyHostBuilder builder)
    {
        // Logging
        builder.Logging.SetMinimumLevel(LogLevel.Information);

        
        // Fusion
        var fusion = services.AddFusion();
        var baseUri = new Uri(builder.HostEnvironment.BaseAddress);
        fusion.Rpc.AddWebSocketClient(baseUri);

        // Fusion service clients
        fusion.AddClient<IPeopleService>();

        ConfigureSharedServices(services);
    }
    public static void ConfigureSharedServices(IServiceCollection services)
    {
        //services.AddScoped<AppState>();
        
        // Other UI-related services
        var fusion = services.AddFusion();
        fusion.AddService<AppState>();
        fusion.AddBlazor();
        fusion.AddFusionTime();

        // Default update delay is set to 0.1s
        services.AddTransient<IUpdateDelayer>(c => new UpdateDelayer(c.UIActionTracker(), 0.1));
    }
}