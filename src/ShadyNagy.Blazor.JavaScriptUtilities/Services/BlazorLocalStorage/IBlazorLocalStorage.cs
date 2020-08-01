using System.Threading.Tasks;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public interface IBlazorLocalStorage
    {
        Task<bool> IsAvailableAsync();
    }
}
