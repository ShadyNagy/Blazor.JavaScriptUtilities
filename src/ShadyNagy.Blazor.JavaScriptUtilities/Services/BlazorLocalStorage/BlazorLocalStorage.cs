using System.Threading.Tasks;
using Microsoft.JSInterop;
using ShadyNagy.Blazor.JavaScriptUtilities.Constants;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public class BlazorLocalStorage : IBlazorLocalStorage, ISyncBlazorLocalStorage
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly IJSInProcessRuntime _jsInProcessRuntime;

        public BlazorLocalStorage(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
            _jsInProcessRuntime = jSRuntime as IJSInProcessRuntime;
        }

        public async Task<bool> IsAvailableAsync()
        {
            return await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.LocalStorageAvailable);
        }




        public bool IsAvailable()
        {
            return _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.LocalStorageAvailable);
        }
    }
}
