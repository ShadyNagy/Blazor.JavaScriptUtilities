using Microsoft.Extensions.DependencyInjection;
using ShadyNagy.Blazor.JavaScriptUtilities.Services;

namespace ShadyNagy.Blazor.JavaScriptUtilities
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorCookie(this IServiceCollection services)
        {
            services.AddScoped<IBlazorCookie, BlazorCookie>();
            return services.AddScoped<ISyncBlazorCookie, BlazorCookie>();
        }

        public static IServiceCollection AddBlazorScrollController(this IServiceCollection services)
        {
            services.AddScoped<IBlazorScrollController, BlazorScrollController>();
            return services.AddScoped<ISyncBlazorScrollController, BlazorScrollController>();
        }
    }
}
