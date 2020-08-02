using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public interface ISyncBlazorLocalStorage
    {
        bool IsAvailable();
        bool Set(string key, string value);
        string Get(string key);
        int Count();
        bool Remove(string key);
        bool Clear();
        Dictionary<string, string> GetAll();
        event Action OnChange;
        void AddStorageListener();
        string GetChangedKey();
        ChangedLocalStorage GetChangedLocalStorage();
    }
}
