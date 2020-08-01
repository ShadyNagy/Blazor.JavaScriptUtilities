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
        }

        
    }
}
