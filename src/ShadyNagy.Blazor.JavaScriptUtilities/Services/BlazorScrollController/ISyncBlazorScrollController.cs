using ShadyNagy.Blazor.JavaScriptUtilities.Constants;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public interface ISyncBlazorScrollController
    {
        void HideScrollOverflowByTag(string tagName, ScrollType scrollType);
        void ShowScrollOverflowByTag(string tagName, ScrollType scrollType);
        void HideScrollOverflowByClass(string className, ScrollType scrollType);
        void ShowScrollOverflowByClass(string className, ScrollType scrollType);
        void HideBodyScrollOverflow(ScrollType scrollType);
        void ShowBodyScrollOverflow(ScrollType scrollType);
    }
}
