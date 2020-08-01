using Microsoft.Extensions.DependencyInjection;
using ShadyNagy.Blazor.JavaScriptUtilities.Services;

namespace ShadyNagy.Blazor.JavaScriptUtilities
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAllBlazorJavaScriptUtilities(this IServiceCollection services)
        {
            services.AddBlazorLocalStorage();
            services.AddBlazorCookie();
            return services.AddBlazorScrollController();
        }

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

        public static IServiceCollection AddBlazorLocalStorage(this IServiceCollection services)
        {
            services.AddScoped<IBlazorLocalStorage, BlazorLocalStorage>();
            return services.AddScoped<ISyncBlazorLocalStorage, BlazorLocalStorage>();
        }
    }
}
