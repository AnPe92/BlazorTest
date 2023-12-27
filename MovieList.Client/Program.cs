using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MovieList.Client.Services;
using MovieList.Client.Services.Interfaces;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});
builder.Services.AddScoped<IMovieService>();
await builder.Build().RunAsync();