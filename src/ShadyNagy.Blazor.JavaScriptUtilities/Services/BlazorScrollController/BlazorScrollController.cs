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
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.ScrollController.HideScrollOverflowByTag, tagName, scrollType);
        }

        public async Task ShowScrollOverflowByTagAsync(string tagName, ScrollType scrollType)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.ScrollController.ShowScrollOverflowByTag, tagName, scrollType);
        }

        public async Task HideScrollOverflowByClassAsync(string className, ScrollType scrollType)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.ScrollController.HideScrollOverflowByClass, className, scrollType);
        }

        public async Task ShowScrollOverflowByClassAsync(string className, ScrollType scrollType)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.ScrollController.ShowScrollOverflowByClass, className, scrollType);
        }

        public async Task HideBodyScrollOverflowAsync(ScrollType scrollType)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.ScrollController.HideScrollOverflowByTag, "body", scrollType);
        }

        public async Task ShowBodyScrollOverflowAsync(ScrollType scrollType)
        {
            await _jsRuntime.InvokeAsync<string>(JSInteropConstants.ScrollController.ShowScrollOverflowByTag, "body", scrollType);
        }

        public void HideScrollOverflowByTag(string tagName, ScrollType scrollType)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.ScrollController.HideScrollOverflowByTag, tagName, scrollType);
        }

        public void ShowScrollOverflowByTag(string tagName, ScrollType scrollType)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.ScrollController.ShowScrollOverflowByTag, tagName, scrollType);
        }

        public void HideScrollOverflowByClass(string className, ScrollType scrollType)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.ScrollController.HideScrollOverflowByClass, className, scrollType);
        }

        public void ShowScrollOverflowByClass(string className, ScrollType scrollType)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.ScrollController.ShowScrollOverflowByClass, className, scrollType);
        }

        public void HideBodyScrollOverflow(ScrollType scrollType)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.ScrollController.HideScrollOverflowByTag, "body", scrollType);
        }

        public void ShowBodyScrollOverflow(ScrollType scrollType)
        {
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.ScrollController.ShowScrollOverflowByTag, "body", scrollType);
        }
    }
}
