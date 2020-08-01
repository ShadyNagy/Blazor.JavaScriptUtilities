using System.Threading.Tasks;
using ShadyNagy.Blazor.JavaScriptUtilities.Constants;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public interface IBlazorScrollController
    {
        Task HideScrollOverflowByTagAsync(string tagName, ScrollType scrollType);
        Task ShowScrollOverflowByTagAsync(string tagName, ScrollType scrollType);
        Task HideScrollOverflowByClassAsync(string className, ScrollType scrollType);
        Task ShowScrollOverflowByClassAsync(string className, ScrollType scrollType);
        Task HideBodyScrollOverflowAsync(ScrollType scrollType);
        Task ShowBodyScrollOverflowAsync(ScrollType scrollType);
    }
}
