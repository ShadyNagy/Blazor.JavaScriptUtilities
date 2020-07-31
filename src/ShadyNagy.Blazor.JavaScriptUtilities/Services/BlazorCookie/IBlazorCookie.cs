using System.Threading.Tasks;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public interface IBlazorCookie
    {
        Task DeleteCookieAsync(string name);
        Task<string> GetCookieAsync(string name);
    }
}
