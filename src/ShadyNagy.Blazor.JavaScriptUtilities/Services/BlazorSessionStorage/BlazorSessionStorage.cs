using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using ShadyNagy.Blazor.JavaScriptUtilities.Constants;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public class BlazorSessionStorage : IBlazorSessionStorage, ISyncBlazorSessionStorage
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly IJSInProcessRuntime _jsInProcessRuntime;
        private void NotifyStorageChanged() => OnChange?.Invoke();
        private ChangedSessionStorage ChangedSessionStorage { get; set; }

        public event Action OnChange;

        public BlazorSessionStorage(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
            _jsInProcessRuntime = jSRuntime as IJSInProcessRuntime;
        }

        [JSInvokable]
        public void StorageChange(string data)
        {
            ChangedSessionStorage = new ChangedSessionStorage(data);
            NotifyStorageChanged();
        }

        public async Task<bool> IsAvailableAsync()
        {
            return await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.Storage.Available, "sessionStorage");
        }

        public async Task<bool> SetAsync(string key, string value)
        {
            return await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.Storage.Set, "sessionStorage", key, value);
        }

        public async Task<string> GetAsync(string key)
        {
            return await _jsRuntime.InvokeAsync<string>(JSInteropConstants.Storage.Get, "sessionStorage", key);
        }

        public async Task<int> CountAsync()
        {
            return await _jsRuntime.InvokeAsync<int>(JSInteropConstants.Storage.Count, "sessionStorage");
        }

        public async Task<bool> RemoveAsync(string key)
        {
            return await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.Storage.Remove, "sessionStorage", key);
        }

        public async Task<bool> ClearAsync()
        {
            return await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.Storage.Clear, "sessionStorage");
        }

        public async Task<Dictionary<string, string>> GetAllAsync()
        {
            var result = new Dictionary<string, string>();

            var localStorageList = await _jsRuntime.InvokeAsync<string[]>(JSInteropConstants.Storage.GetAll, "sessionStorage");
            if (localStorageList == null || localStorageList.Length <= 0)
            {
                return result;
            }

            result = localStorageList.Select(item => item.Split('=')).ToDictionary(s => s[0], s => s[1]);
            return result;
        }

        public async Task AddStorageListenerAsync()
        {
            var thisReference = DotNetObjectReference.Create(this);
            await _jsRuntime.InvokeAsync<object>(JSInteropConstants.Storage.AddListener, thisReference);
        }

        public bool IsAvailable()
        {
            return _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.Storage.Available, "sessionStorage");
        }

        public bool Set(string key, string value)
        {
            return _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.Storage.Set, "sessionStorage", key, value);
        }

        public string Get(string key)
        {
            return _jsInProcessRuntime.Invoke<string>(JSInteropConstants.Storage.Get, "sessionStorage", key);
        }

        public int Count()
        {
            return _jsInProcessRuntime.Invoke<int>(JSInteropConstants.Storage.Count, "sessionStorage");
        }

        public bool Remove(string key)
        {
            return _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.Storage.Remove, "sessionStorage", key);
        }

        public bool Clear()
        {
            return _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.Storage.Clear, "sessionStorage");
        }

        public Dictionary<string, string> GetAll()
        {
            var result = new Dictionary<string, string>();

            var localStorageList = _jsInProcessRuntime.Invoke<string[]>(JSInteropConstants.Storage.GetAll, "sessionStorage");
            if (localStorageList == null || localStorageList.Length <= 0)
            {
                return result;
            }

            result = localStorageList.Select(item => item.Split('=')).ToDictionary(s => s[0], s => s[1]);
            return result;
        }

        public void AddStorageListener()
        {
            var thisReference = DotNetObjectReference.Create(this);
            _jsInProcessRuntime.Invoke<string>(JSInteropConstants.Storage.AddListener, thisReference);
        }

        public string GetChangedKey()
        {
            return ChangedSessionStorage.Key;
        }

        public ChangedSessionStorage GetChangedSessionStorage()
        {
            return ChangedSessionStorage;
        }
    }
}
