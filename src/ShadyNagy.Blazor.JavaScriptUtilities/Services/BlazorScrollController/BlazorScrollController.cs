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

        public async Task HideScrollOverflowByTagAsync(string tagName, ScrollType scrollType)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.HideScrollOverflowByTag, tagName, scrollType);
        }

        public async Task ShowScrollOverflowByTagAsync(string tagName, ScrollType scrollType)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.ShowScrollOverflowByTag, tagName, scrollType);
        }

        public async Task HideScrollOverflowByClassAsync(string className, ScrollType scrollType)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.HideScrollOverflowByClass, className, scrollType);
        }

        public async Task ShowScrollOverflowByClassAsync(string className, ScrollType scrollType)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.ShowScrollOverflowByClass, className, scrollType);
        }

        public async Task HideBodyScrollOverflowAsync(ScrollType scrollType)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.HideScrollOverflowByTag, "body", scrollType);
        }

        public async Task ShowBodyScrollOverflowAsync(ScrollType scrollType)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.ShowScrollOverflowByTag, "body", scrollType);
        }

        public void HideScrollOverflowByTag(string tagName, ScrollType scrollType)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.HideScrollOverflowByTag, tagName, scrollType);
        }

        public void ShowScrollOverflowByTag(string tagName, ScrollType scrollType)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.ShowScrollOverflowByTag, tagName, scrollType);
        }

        public void HideScrollOverflowByClass(string className, ScrollType scrollType)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.HideScrollOverflowByClass, className, scrollType);
        }

        public void ShowScrollOverflowByClass(string className, ScrollType scrollType)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.ShowScrollOverflowByClass, className, scrollType);
        }

        public void HideBodyScrollOverflow(ScrollType scrollType)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.HideScrollOverflowByTag, "body", scrollType);
        }

        public void ShowBodyScrollOverflow(ScrollType scrollType)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.ShowScrollOverflowByTag, "body", scrollType);
        }
    }
}
