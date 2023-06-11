using BlazorApp3;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Njg3NTU2QDMyMzAyZTMyMmUzMFEwTUdPNW5SZm55dlk3WFRoaUpLbmh0ODA5YkVSZUtoOE9NUlhLaHAwcTA9")