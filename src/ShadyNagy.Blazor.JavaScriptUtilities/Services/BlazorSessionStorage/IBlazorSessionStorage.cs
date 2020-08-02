using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public interface IBlazorSessionStorage
    {
        Task<bool> IsAvailableAsync();
        Task<bool> SetAsync(string key, string value);
        Task<string> GetAsync(string key);
        Task<int> CountAsync();
        Task<bool> RemoveAsync(string key);
        Task<bool> ClearAsync();
        Task<Dictionary<string, string>> GetAllAsync();
        event Action OnChange;
        Task AddStorageListenerAsync();
        string GetChangedKey();
        ChangedSessionStorage GetChangedSessionStorage();
    }
}
