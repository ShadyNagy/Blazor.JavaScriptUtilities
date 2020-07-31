namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public interface ISyncBlazorCookie
    {
        void DeleteCookie(string name);
        string GetCookie(string name);
    }
}
