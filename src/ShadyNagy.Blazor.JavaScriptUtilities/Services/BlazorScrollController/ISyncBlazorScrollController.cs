namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public interface ISyncBlazorScrollController
    {
        void HideScrollOverflowByTag(string tagName);
        void ShowScrollOverflowByTag(string tagName);
        void HideScrollOverflowByClass(string className);
        void ShowScrollOverflowByClass(string className);
    }
}
