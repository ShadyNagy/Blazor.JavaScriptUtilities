using System.Threading.Tasks;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public interface IBlazorScrollController
    {
        Task HideScrollOverflowByTagAsync(string tagName);
        Task ShowScrollOverflowByTagAsync(string tagName);
    }
}
