using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorClient.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Blazored.Toast;

namespace BlazorClient.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services
                .AddHttpClient("BlazorApp7.ServerAPI",
                client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
                //.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BlazorApp7.ServerAPI"));
            builder.Services.AddApiAuthorization();
            builder.Services.AddBlazoredLocalStorage(config =>
            config.JsonSerializerOptions.WriteIndented = true);
            builder.Services.AddBlazoredToast();
            await builder.Build().RunAsync();
        }
    }
}
