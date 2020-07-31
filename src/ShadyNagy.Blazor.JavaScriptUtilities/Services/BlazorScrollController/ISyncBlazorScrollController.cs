namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public interface ISyncBlazorScrollController
    {
        void HideScrollOverflowByTag(string tagName);
        void ShowScrollOverflowByTag(string tagName);
    }
}
