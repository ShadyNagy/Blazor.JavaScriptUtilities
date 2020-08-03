using System.Threading.Tasks;
using ShadyNagy.Blazor.JavaScriptUtilities.Constants;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public interface IBlazorScrollController
    {
        Task HideScrollOverflowByTagAsync(string tagName, ScrollType scrollType);
        Task ShowScrollOverflowByTagAsync(string tagName, ScrollType scrollType);
        Task HideScrollOverflowByClassAsync(string className, ScrollType scrollType);
        Task ShowScrollOverflowByClassAsync(string className, ScrollType scrollType);
        Task HideBodyScrollOverflowAsync(ScrollType scrollType);
        Task ShowBodyScrollOverflowAsync(ScrollType scrollType);
        Task<bool> ScrollToAsync(int top, int left, string behavior = "auto");



        Task<bool> ScrollVToElementByIdAsync(string elementId, string behavior = "auto", string block = "start");
        Task<bool> ScrollVToElementByTagAsync(string tagName, string behavior = "auto", string block = "start");
        Task<bool> ScrollVToElementByClassAsync(string className, string behavior = "auto", string block = "start");
        Task<bool> ScrollHToElementByIdAsync(string elementId, string behavior = "auto", string inline = "nearest");
        Task<bool> ScrollHToElementByTagAsync(string tagName, string behavior = "auto", string inline = "nearest");
        Task<bool> ScrollHToElementByClassAsync(string className, string behavior = "auto", string inline = "nearest");

        Task<bool> ScrollToBodyAsync(string behavior = "auto", string block = "start");
        Task<bool> ScrollToBodyTopAsync(string behavior = "auto");
        Task<bool> ScrollToBodyBottomAsync(string behavior = "auto");



        Task<bool> ScrollElementToByElementIdAsync(string elementId, int top, int left, string behavior = "auto");
        Task<bool> ScrollElementToByTagNameAsync(string tagName, int top, int left, string behavior = "auto");
        Task<bool> ScrollElementToByClassNameAsync(string className, int top, int left, string behavior = "auto");
        Task<bool> ScrollBodyToAsync(int top, int left, string behavior = "auto");
        Task<int> GetScrollHeightByElementIdAsync(string elementId);
        Task<int> GetScrollHeightByTagNameAsync(string tagName);
        Task<int> GetScrollHeightByClassNameAsync(string className);
        Task<int> GetScrollWidthByElementIdAsync(string elementId);
        Task<int> GetScrollWidthByTagNameAsync(string tagName);
        Task<int> GetScrollWidthByClassNameAsync(string className);
        Task<int> GetScrollLeftByElementIdAsync(string elementId);
        Task<int> GetScrollLeftByTagNameAsync(string tagName);
        Task<int> GetScrollLeftByClassNameAsync(string className);
        Task<int> GetScrollTopByElementIdAsync(string elementId);
        Task<int> GetScrollTopByTagNameAsync(string tagName);
        Task<int> GetScrollTopByClassNameAsync(string className);
        Task<bool> SetScrollLeftByElementIdAsync(string elementId, int value);
        Task<bool> SetScrollLeftByTagNameAsync(string tagName, int value);
        Task<bool> SetScrollLeftByClassNameAsync(string className, int value);
        Task<bool> SetScrollTopByElementIdAsync(string elementId, int value);
        Task<bool> SetScrollTopByTagNameAsync(string tagName, int value);
        Task<bool> SetScrollTopByClassNameAsync(string className, int value);

    }
}
