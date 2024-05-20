using EventManagerFrontend;
using EventManagerFrontend.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<UserState>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7027/") });

await builder.Build().RunAsync();
