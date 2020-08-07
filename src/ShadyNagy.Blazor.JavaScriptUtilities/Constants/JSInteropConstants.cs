using System;
using System.Collections.Generic;
using System.Text;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Constants
{
    internal static class JSInteropConstants
    {
        internal static class Cookie
        {
            internal static string Delete => "deleteCookie";
            internal static string Get => "getCookie";
        }

        internal static class ScrollController
        {
            internal static string HideScrollOverflowByTag => "hideScrollOverflowByTag";
            internal static string ShowScrollOverflowByTag => "showScrollOverflowByTag";
            internal static string HideScrollOverflowByClass => "hideScrollOverflowByClass";
            internal static string ShowScrollOverflowByClass => "showScrollOverflowByClass";
            internal static string ScrollTo => "mainScrollTo";
            internal static string ScrollVToElementById => "scrollVToElementById";
            internal static string ScrollVToElementByTag => "scrollVToElementByTag";
            internal static string ScrollVToElementByClass => "scrollVToElementByClass";
            internal static string ScrollHToElementById => "scrollHToElementById";
            internal static string ScrollHToElementByTag => "scrollHToElementByTag";
            internal static string ScrollHToElementByClass => "scrollHToElementByClass";
            internal static string ScrollElementToByTagName => "scrollElementToByTagName";
            internal static string ScrollElementToByElementId => "scrollElementToByElementId";
            internal static string ScrollElementToByClassName => "scrollElementToByClassName";
            internal static string GetScrollHeightByElementId => "getScrollHeightByElementId";
            internal static string GetScrollHeightByTagName => "getScrollHeightByTagName";
            internal static string GetScrollHeightByClassName => "getScrollHeightByClassName";
            internal static string GetScrollWidthByElementId => "getScrollWidthByElementId";
            internal static string GetScrollWidthByTagName => "getScrollWidthByTagName";
            internal static string GetScrollWidthByClassName => "getScrollWidthByClassName";
            internal static string GetScrollLeftByElementId => "getScrollLeftByElementId";
            internal static string GetScrollLeftByTagName => "getScrollLeftByTagName";
            internal static string GetScrollLeftByClassName => "getScrollLeftByClassName";
            internal static string GetScrollTopByElementId => "getScrollTopByElementId";
            internal static string GetScrollTopByTagName => "getScrollTopByTagName";
            internal static string GetScrollTopByClassName => "getScrollTopByClassName";
            internal static string SetScrollLeftByElementId => "setScrollLeftByElementId";
            internal static string SetScrollLeftByTagName => "setScrollLeftByTagName";
            internal static string SetScrollLeftByClassName => "setScrollLeftByClassName";
            internal static string SetScrollTopByElementId => "setScrollTopByElementId";
            internal static string SetScrollTopByTagName => "setScrollTopByTagName";
            internal static string SetScrollTopByClassName => "setScrollTopByClassName";
        }

        internal static class Storage
        {
            internal static string Available => "storageAvailable";
            internal static string Get => "storageGet";
            internal static string Set => "storageSet";
            internal static string Clear => "storageClear";
            internal static string Remove => "storageRemove";
            internal static string Count => "storageCount";
            internal static string GetAll => "storageGetAll";
            internal static string AddListener => "storageListener";
        }

        internal static class File
        {
            internal static string DownloadFromUrl => "downloadFromUrl";
        }

        internal static class Dialog
        {
            internal static string ShowAlert => "showAlert";
            internal static string ShowPrompt => "showPrompt";
            internal static string ShowConfirm => "showConfirm";
        }
    }
}
