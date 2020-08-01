using System.Threading.Tasks;
using Microsoft.JSInterop;
using ShadyNagy.Blazor.JavaScriptUtilities.Constants;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public class BlazorScrollController: IBlazorScrollController, ISyncBlazorScrollController
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly IJSInProcessRuntime _jsInProcessRuntime;

        public BlazorScrollController(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
            _jsInProcessRuntime = jSRuntime as IJSInProcessRuntime;
        }

        public async Task HideBodyScrollOverflow()
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.HideScrollOverflowByTag, "body");
        }

        public async Task ShowBodyScrollOverflow()
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.ShowScrollOverflowByTag, "body");
        }

        public async Task HideScrollOverflowByTagAsync(string tagName)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.HideScrollOverflowByTag, tagName);
        }

        public async Task ShowScrollOverflowByTagAsync(string tagName)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.ShowScrollOverflowByTag, tagName);
        }

        public void HideScrollOverflowByTag(string tagName)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.HideScrollOverflowByTag, tagName);
        }

        public void ShowScrollOverflowByTag(string tagName)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.ShowScrollOverflowByTag, tagName);
        }

        public async Task HideScrollOverflowByClassAsync(string className)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.HideScrollOverflowByClass, className);
        }

        public async Task ShowScrollOverflowByClassAsync(string className)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.ShowScrollOverflowByClass, className);
        }

        public void HideScrollOverflowByClass(string className)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.HideScrollOverflowByClass, className);
        }

        public void ShowScrollOverflowByClass(string className)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.ShowScrollOverflowByClass, className);
        }
    }
}
