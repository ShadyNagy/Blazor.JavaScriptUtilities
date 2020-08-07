using System.Threading.Tasks;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public interface IBlazorDialog
    {
        Task<bool> ShowAlertAsync(string message);
        Task<string> ShowPromptAsync(string message, string defaultResponse = "");
        Task<bool> ShowConfirmAsync(string message);
    }
}
