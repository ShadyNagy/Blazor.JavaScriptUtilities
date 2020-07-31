using System.Threading.Tasks;
using Microsoft.JSInterop;
using ShadyNagy.Blazor.JavaScriptUtilities.Constants;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public class BlazorCookie: IBlazorCookie, ISyncBlazorCookie
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly IJSInProcessRuntime _jsInProcessRuntime;

        public BlazorCookie(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
            _jsInProcessRuntime = jSRuntime as IJSInProcessRuntime;
        }

        public async Task DeleteCookieAsync(string name)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.DeleteCookie, name);
        }

        public async Task<string> GetCookieAsync(string name)
        {
            return await _jsRuntime.InvokeAsync<string>(JSInteropConstants.GetCookie, name);
        }

        public void DeleteCookie(string name)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.DeleteCookie, name);
        }

        public string GetCookie(string name)
        {
            return _jsInProcessRuntime.Invoke<string>(JSInteropConstants.GetCookie, name);
        }
    }
}
