using System.Threading.Tasks;
using Microsoft.JSInterop;
using ShadyNagy.Blazor.JavaScriptUtilities.Constants;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public class BlazorDialog : IBlazorDialog, ISyncBlazorDialog
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly IJSInProcessRuntime _jsInProcessRuntime;

        public BlazorDialog(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
            _jsInProcessRuntime = jSRuntime as IJSInProcessRuntime;
        }

        public async Task<bool> ShowAlertAsync(string message)
        {
            return await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.Dialog.ShowAlert, message);
        }

        public async Task<string> ShowPromptAsync(string message, string defaultResponse = "")
        {
            return await _jsRuntime.InvokeAsync<string>(JSInteropConstants.Dialog.ShowPrompt, message, defaultResponse);
        }

        public async Task<bool> ShowConfirmAsync(string message)
        {
            return await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.Dialog.ShowConfirm, message);
        }

        public bool ShowAlert(string message)
        {
            return _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.Dialog.ShowAlert, message);
        }

        public string ShowPrompt(string message, string defaultResponse = "")
        {
            return _jsInProcessRuntime.Invoke<string>(JSInteropConstants.Dialog.ShowPrompt, message, defaultResponse);
        }

        public bool ShowConfirm(string message)
        {
            return _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.Dialog.ShowConfirm, message);
        }
    }
}
