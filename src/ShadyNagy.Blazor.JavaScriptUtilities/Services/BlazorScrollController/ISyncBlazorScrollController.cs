using ShadyNagy.Blazor.JavaScriptUtilities.Constants;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    interface ISyncBlazorScrollController
    {
        void HideScrollOverflowByTag(string tagName, ScrollType scrollType);
        void ShowScrollOverflowByTag(string tagName, ScrollType scrollType);
        void HideScrollOverflowByClass(string className, ScrollType scrollType);
        void ShowScrollOverflowByClass(string className, ScrollType scrollType);
        void HideBodyScrollOverflow(ScrollType scrollType);
        void ShowBodyScrollOverflow(ScrollType scrollType);
        bool ScrollTo(int top, int left, string behavior = "auto");
        bool ScrollVToElementById(string elementId, string behavior = "auto", string block = "start");
        bool ScrollVToElementByTag(string tagName, string behavior = "auto", string block = "start");
        bool ScrollVToElementByClass(string className, string behavior = "auto", string block = "start");
        bool ScrollHToElementById(string elementId, string behavior = "auto", string inline = "nearest");
        bool ScrollHToElementByTag(string tagName, string behavior = "auto", string inline = "nearest");
        bool ScrollHToElementByClass(string className, string behavior = "auto", string inline = "nearest");
        bool ScrollToBody(string behavior = "auto", string block = "start");
        bool ScrollToBodyTop(string behavior = "auto");
        bool ScrollToBodyBottom(string behavior = "auto");
        bool ScrollElementToByElementId(string elementId, int top, int left, string behavior = "auto");
        bool ScrollElementToByTagName(string tagName, int top, int left, string behavior = "auto");
        bool ScrollElementToByClassName(string className, int top, int left, string behavior = "auto");
        bool ScrollBodyTo(int top, int left, string behavior = "auto");
        int GetScrollHeightByElementId(string elementId);
        int GetScrollHeightByTagName(string tagName);
        int GetScrollHeightByClassName(string className);
        int GetScrollWidthByElementId(string elementId);
        int GetScrollWidthByTagName(string tagName);
        int GetScrollWidthByClassName(string className);
        int GetScrollLeftByElementId(string elementId);
        int GetScrollLeftByTagName(string tagName);
        int GetScrollLeftByClassName(string className);
        int GetScrollTopByElementId(string elementId);
        int GetScrollTopByTagName(string tagName);
        int GetScrollTopByClassName(string className);
        bool SetScrollLeftByElementId(string elementId, int value);
        bool SetScrollLeftByTagName(string tagName, int value);
        bool SetScrollLeftByClassName(string className, int value);
        bool SetScrollTopByElementId(string elementId, int value);
        bool SetScrollTopByTagName(string tagName, int value);
        bool SetScrollTopByClassName(string className, int value);
    }
}
