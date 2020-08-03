using System.Threading.Tasks;
using Microsoft.JSInterop;
using ShadyNagy.Blazor.JavaScriptUtilities.Constants;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public class BlazorScrollController : IBlazorScrollController, ISyncBlazorScrollController
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

        public async Task<bool> ScrollToAsync(int top, int left, string behavior = "auto") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollTo, top, left, behavior);

        public async Task<bool> ScrollVToElementByIdAsync(string elementId, string behavior = "auto", string block = "start") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollVToElementById, elementId, behavior, block);

        public async Task<bool> ScrollVToElementByTagAsync(string tagName, string behavior = "auto", string block = "start") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollVToElementByTag, tagName, behavior, block);

        public async Task<bool> ScrollVToElementByClassAsync(string className, string behavior = "auto", string block = "start") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollVToElementByClass, className, behavior, block);

        public async Task<bool> ScrollHToElementByIdAsync(string elementId, string behavior = "auto", string inline = "nearest") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollHToElementById, elementId, behavior, inline);

        public async Task<bool> ScrollHToElementByTagAsync(string tagName, string behavior = "auto", string inline = "nearest") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollHToElementByTag, tagName, behavior, inline);

        public async Task<bool> ScrollHToElementByClassAsync(string className, string behavior = "auto", string inline = "nearest") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollHToElementByClass, className, behavior, inline);


        public async Task<bool> ScrollToBodyAsync(string behavior = "auto", string block = "start") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollVToElementByTag, "body", behavior, block);

        public async Task<bool> ScrollToBodyTopAsync(string behavior = "auto") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollVToElementByTag, "body", behavior, ScrollBlocks.Start);

        public async Task<bool> ScrollToBodyBottomAsync(string behavior = "auto") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollVToElementByTag, "body", behavior, ScrollBlocks.End);

        public async Task<bool> ScrollElementToByElementIdAsync(string elementId, int top, int left, string behavior = "auto") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollElementToByElementId, elementId, top, left, behavior);

        public async Task<bool> ScrollElementToByTagNameAsync(string tagName, int top, int left, string behavior = "auto") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollElementToByTagName, tagName, top, left, behavior);

        public async Task<bool> ScrollElementToByClassNameAsync(string className, int top, int left, string behavior = "auto") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollElementToByClassName, className, top, left, behavior);

        public async Task<bool> ScrollBodyToAsync(int top, int left, string behavior = "auto") =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.ScrollElementToByTagName, "body", top, left, behavior);

        public async Task<int> GetScrollHeightByElementIdAsync(string elementId) =>
            await _jsRuntime.InvokeAsync<int>(JSInteropConstants.ScrollController.GetScrollHeightByElementId, elementId);

        public async Task<int> GetScrollHeightByTagNameAsync(string tagName) =>
            await _jsRuntime.InvokeAsync<int>(JSInteropConstants.ScrollController.GetScrollHeightByTagName, tagName);

        public async Task<int> GetScrollHeightByClassNameAsync(string className) =>
            await _jsRuntime.InvokeAsync<int>(JSInteropConstants.ScrollController.GetScrollHeightByClassName, className);

        public async Task<int> GetScrollWidthByElementIdAsync(string elementId) =>
            await _jsRuntime.InvokeAsync<int>(JSInteropConstants.ScrollController.GetScrollWidthByElementId, elementId);

        public async Task<int> GetScrollWidthByTagNameAsync(string tagName) =>
            await _jsRuntime.InvokeAsync<int>(JSInteropConstants.ScrollController.GetScrollWidthByTagName, tagName);

        public async Task<int> GetScrollWidthByClassNameAsync(string className) =>
            await _jsRuntime.InvokeAsync<int>(JSInteropConstants.ScrollController.GetScrollWidthByClassName, className);

        public async Task<int> GetScrollLeftByElementIdAsync(string elementId) =>
            await _jsRuntime.InvokeAsync<int>(JSInteropConstants.ScrollController.GetScrollLeftByElementId, elementId);

        public async Task<int> GetScrollLeftByTagNameAsync(string tagName) =>
            await _jsRuntime.InvokeAsync<int>(JSInteropConstants.ScrollController.GetScrollLeftByTagName, tagName);

        public async Task<int> GetScrollLeftByClassNameAsync(string className) =>
            await _jsRuntime.InvokeAsync<int>(JSInteropConstants.ScrollController.GetScrollLeftByClassName, className);

        public async Task<int> GetScrollTopByElementIdAsync(string elementId) =>
            await _jsRuntime.InvokeAsync<int>(JSInteropConstants.ScrollController.GetScrollTopByElementId, elementId);

        public async Task<int> GetScrollTopByTagNameAsync(string tagName) =>
            await _jsRuntime.InvokeAsync<int>(JSInteropConstants.ScrollController.GetScrollTopByTagName, tagName);

        public async Task<int> GetScrollTopByClassNameAsync(string className) =>
            await _jsRuntime.InvokeAsync<int>(JSInteropConstants.ScrollController.GetScrollTopByClassName, className);

        public async Task<bool> SetScrollLeftByElementIdAsync(string elementId, int value) =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.SetScrollLeftByElementId, elementId, value);

        public async Task<bool> SetScrollLeftByTagNameAsync(string tagName, int value) =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.SetScrollLeftByTagName, tagName, value);

        public async Task<bool> SetScrollLeftByClassNameAsync(string className, int value) =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.SetScrollLeftByClassName, className, value);

        public async Task<bool> SetScrollTopByElementIdAsync(string elementId, int value) =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.SetScrollTopByElementId, elementId, value);

        public async Task<bool> SetScrollTopByTagNameAsync(string tagName, int value) =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.SetScrollTopByTagName, tagName, value);

        public async Task<bool> SetScrollTopByClassNameAsync(string className, int value) =>
            await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.ScrollController.SetScrollTopByClassName, className, value);



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

        public bool ScrollTo(int top, int left, string behavior = "auto") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollTo, top, left, behavior);

        public bool ScrollVToElementById(string elementId, string behavior = "auto", string block = "start") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollVToElementById, elementId, behavior, block);

        public bool ScrollVToElementByTag(string tagName, string behavior = "auto", string block = "start") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollVToElementByTag, tagName, behavior, block);

        public bool ScrollVToElementByClass(string className, string behavior = "auto", string block = "start") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollVToElementByClass, className, behavior, block);

        public bool ScrollHToElementById(string elementId, string behavior = "auto", string inline = "nearest") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollHToElementById, elementId, behavior, inline);

        public bool ScrollHToElementByTag(string tagName, string behavior = "auto", string inline = "nearest") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollHToElementByTag, tagName, behavior, inline);

        public bool ScrollHToElementByClass(string className, string behavior = "auto", string inline = "nearest") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollHToElementByClass, className, behavior, inline);

        public bool ScrollToBody(string behavior = "auto", string block = "start") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollVToElementByTag, "body", behavior, block);

        public bool ScrollToBodyTop(string behavior = "auto") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollVToElementByTag, "body", behavior, ScrollBlocks.Start);

        public bool ScrollToBodyBottom(string behavior = "auto") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollVToElementByTag, "body", behavior, ScrollBlocks.End);

        public bool ScrollElementToByElementId(string elementId, int top, int left, string behavior = "auto") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollElementToByElementId, elementId, top, left, behavior);

        public bool ScrollElementToByTagName(string tagName, int top, int left, string behavior = "auto") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollElementToByTagName, tagName, top, left, behavior);

        public bool ScrollElementToByClassName(string className, int top, int left, string behavior = "auto") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollElementToByClassName, className, top, left, behavior);

        public bool ScrollBodyTo(int top, int left, string behavior = "auto") =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.ScrollElementToByTagName, "body", top, left, behavior);

        public int GetScrollHeightByElementId(string elementId) =>
            _jsInProcessRuntime.Invoke<int>(JSInteropConstants.ScrollController.GetScrollHeightByElementId, elementId);

        public int GetScrollHeightByTagName(string tagName) =>
            _jsInProcessRuntime.Invoke<int>(JSInteropConstants.ScrollController.GetScrollHeightByTagName, tagName);

        public int GetScrollHeightByClassName(string className) =>
            _jsInProcessRuntime.Invoke<int>(JSInteropConstants.ScrollController.GetScrollHeightByClassName, className);

        public int GetScrollWidthByElementId(string elementId) =>
            _jsInProcessRuntime.Invoke<int>(JSInteropConstants.ScrollController.GetScrollWidthByElementId, elementId);

        public int GetScrollWidthByTagName(string tagName) =>
            _jsInProcessRuntime.Invoke<int>(JSInteropConstants.ScrollController.GetScrollWidthByTagName, tagName);

        public int GetScrollWidthByClassName(string className) =>
            _jsInProcessRuntime.Invoke<int>(JSInteropConstants.ScrollController.GetScrollWidthByClassName, className);

        public int GetScrollLeftByElementId(string elementId) =>
            _jsInProcessRuntime.Invoke<int>(JSInteropConstants.ScrollController.GetScrollLeftByElementId, elementId);

        public int GetScrollLeftByTagName(string tagName) =>
            _jsInProcessRuntime.Invoke<int>(JSInteropConstants.ScrollController.GetScrollLeftByTagName, tagName);

        public int GetScrollLeftByClassName(string className) =>
            _jsInProcessRuntime.Invoke<int>(JSInteropConstants.ScrollController.GetScrollLeftByClassName, className);

        public int GetScrollTopByElementId(string elementId) =>
            _jsInProcessRuntime.Invoke<int>(JSInteropConstants.ScrollController.GetScrollTopByElementId, elementId);

        public int GetScrollTopByTagName(string tagName) =>
            _jsInProcessRuntime.Invoke<int>(JSInteropConstants.ScrollController.GetScrollTopByTagName, tagName);

        public int GetScrollTopByClassName(string className) =>
            _jsInProcessRuntime.Invoke<int>(JSInteropConstants.ScrollController.GetScrollTopByClassName, className);

        public bool SetScrollLeftByElementId(string elementId, int value) =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.SetScrollLeftByElementId, elementId, value);

        public bool SetScrollLeftByTagName(string tagName, int value) =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.SetScrollLeftByTagName, tagName, value);

        public bool SetScrollLeftByClassName(string className, int value) =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.SetScrollLeftByClassName, className, value);

        public bool SetScrollTopByElementId(string elementId, int value) =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.SetScrollTopByElementId, elementId, value);

        public bool SetScrollTopByTagName(string tagName, int value) =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.SetScrollTopByTagName, tagName, value);

        public bool SetScrollTopByClassName(string className, int value) =>
            _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.ScrollController.SetScrollTopByClassName, className, value);
    }
}
