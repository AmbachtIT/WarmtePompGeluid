using MudBlazor.Services;
using WarmtePompGeluid.Wasm.Services;

namespace WarmtePompGeluid.Wasm
{
    public static class DI
    {

        public static IServiceCollection AddWarmtePompGeluidWasm(this IServiceCollection services, string baseAddress)
        {
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });
            services.AddMudServices();
            services.AddScoped<CalculatorService>();

            return services;
        }

    }
}
