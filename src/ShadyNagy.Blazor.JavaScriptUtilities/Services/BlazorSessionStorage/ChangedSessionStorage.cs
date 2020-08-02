using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;

namespace ShadyNagy.Blazor.JavaScriptUtilities.Services
{
    public class ChangedSessionStorage
    {
        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public string Key { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string Url { get; set; }

        public ChangedSessionStorage()
        {
            InitValues();
        }

        public ChangedSessionStorage(string jsonData)
        {
            try
            {
                var result = JsonSerializer.Deserialize<ChangedSessionStorage>(jsonData, JsonOptions);
                Key = result.Key;
                OldValue = result.OldValue;
                NewValue = result.NewValue;
                Url = result.Url;
            }
            catch (Exception)
            {
                InitValues();
            }
        }

        private void InitValues()
        {
            Key = string.Empty;
            OldValue = string.Empty;
            NewValue = string.Empty;
            Url = string.Empty;
        }
    }
}
