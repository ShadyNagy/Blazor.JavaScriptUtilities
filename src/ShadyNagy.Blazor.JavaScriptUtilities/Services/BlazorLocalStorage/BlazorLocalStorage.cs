using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using ShadyNagy.Blazor.JavaScriptUtilities.Constants;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public class BlazorLocalStorage : IBlazorLocalStorage, ISyncBlazorLocalStorage
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly IJSInProcessRuntime _jsInProcessRuntime;

        public BlazorLocalStorage(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
            _jsInProcessRuntime = jSRuntime as IJSInProcessRuntime;
        }

        public async Task<bool> IsAvailableAsync()
        {
            return await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.Storage.Available, "localStorage");
        }

        public async Task<bool> SetAsync(string key, string value)
        {
            return await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.Storage.Set, "localStorage", key, value);
        }

        public async Task<string> GetAsync(string key)
        {
            return await _jsRuntime.InvokeAsync<string>(JSInteropConstants.Storage.Get, "localStorage", key);
        }

        public async Task<int> CountAsync()
        {
            return await _jsRuntime.InvokeAsync<int>(JSInteropConstants.Storage.Count, "localStorage");
        }

        public async Task<bool> RemoveAsync(string key)
        {
            return await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.Storage.Remove, "localStorage", key);
        }

        public async Task<bool> ClearAsync()
        {
            return await _jsRuntime.InvokeAsync<bool>(JSInteropConstants.Storage.Clear, "localStorage");
        }

        public async Task<Dictionary<string, string>> GetAllAsync()
        {
            var result = new Dictionary<string, string>();

            var localStorageList = await _jsRuntime.InvokeAsync<string[]>(JSInteropConstants.Storage.GetAll, "localStorage");
            if (localStorageList == null || localStorageList.Length <= 0)
            {
                return result;
            }

            result = localStorageList.Select(item => item.Split('=')).ToDictionary(s => s[0], s => s[1]);
            return result;
        }

        public bool IsAvailable()
        {
            return _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.Storage.Available, "localStorage");
        }

        public bool Set(string key, string value)
        {
            return _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.Storage.Set, "localStorage", key, value);
        }

        public string Get(string key)
        {
            return _jsInProcessRuntime.Invoke<string>(JSInteropConstants.Storage.Get, "localStorage", key);
        }

        public int Count()
        {
            return _jsInProcessRuntime.Invoke<int>(JSInteropConstants.Storage.Count, "localStorage");
        }

        public bool Remove(string key)
        {
            return _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.Storage.Remove, "localStorage", key);
        }

        public bool Clear()
        {
            return _jsInProcessRuntime.Invoke<bool>(JSInteropConstants.Storage.Clear, "localStorage");
        }

        public Dictionary<string, string> GetAll()
        {
            var result = new Dictionary<string, string>();

            var localStorageList = _jsInProcessRuntime.Invoke<string[]>(JSInteropConstants.Storage.GetAll, "localStorage");
            if (localStorageList == null || localStorageList.Length <= 0)
            {
                return result;
            }

            result = localStorageList.Select(item => item.Split('=')).ToDictionary(s => s[0], s => s[1]);
            return result;
        }
    }
}
