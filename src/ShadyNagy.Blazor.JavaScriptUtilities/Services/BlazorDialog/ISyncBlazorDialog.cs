namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public interface ISyncBlazorDialog
    {
        bool ShowAlert(string message);
        string ShowPrompt(string message, string defaultResponse = "");
        bool ShowConfirm(string message);
    }
}
