<p align="center">
    <a href="https://www.nuget.org/packages/ShadyNagy.Blazor.JavaScriptUtilities" alt="NuGet">
        <img src="https://img.shields.io/nuget/v/ShadyNagy.Blazor.JavaScriptUtilities" />
    </a>
    <a href="https://www.nuget.org/packages/ShadyNagy.Blazor.JavaScriptUtilities" alt="NuGet">
        <img src="https://img.shields.io/nuget/dt/ShadyNagy.Blazor.JavaScriptUtilities" />
    </a>
    <a href="https://github.com/ShadyNagy/Blazor.JavaScriptUtilities/actions?query=workflow%3A%22publish+ShadyNagy.Blazor.JavaScriptUtilities+to+nuget%22" alt="Workflows">
        <img src="https://github.com/shadynagy/Blazor.JavaScriptUtilities/workflows/publish%20ShadyNagy.Blazor.JavaScriptUtilities%20to%20nuget/badge.svg" />
    </a>
    <a href="https://github.com/ShadyNagy/Blazor.JavaScriptUtilities/graphs/contributors" alt="Contributors">
        <img src="https://img.shields.io/github/contributors/ShadyNagy/Blazor.JavaScriptUtilities" />
    </a>
    <a href="https://github.com/ShadyNagy/Blazor.JavaScriptUtilities/blob/master/LICENSE" alt="license">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" />
    </a>
</p>

# Blazor.JavaScriptUtilities
Utilities by JavaScript for Blazor 
- Local Storage Available to check if available in browser
- Local Storage Set
- Local Storage Read
- Local Storage Remove by key
- Local Storage Read All without keys
- Local Storage Remove All
- Local Storage Count
- Local Storage Listener for changes

- Session Storage Available to check if available in browser
- Session Storage Set
- Session Storage Read
- Session Storage Remove by key
- Session Storage Read All without keys
- Session Storage Remove All
- Session Storage Count
- Session Storage Listener for changes

- Scroll Hide
- Scroll Show
- Scroll To

- Cookie Read
- Cookie Delete 

- Alert
- Prompt
- Confirm


...... and more coming.

![Local Storage](LocalStorageDemo.gif)
![scrollbar-controller](https://user-images.githubusercontent.com/6225593/89104489-0963e000-d41a-11ea-8bf4-9bb8f009449d.gif)

## Give a Star! :star:
If you like or are using this project please give it a star. Thanks!

## Getting Setup

You can install the package via the nuget package manager just search for *ShadyNagy.Blazor.*. You can also install via powershell using the following command.

```powershell
Install-Package ShadyNagy.Blazor.JavaScriptUtilities
```

Or via the dotnet CLI.

```bash
dotnet add package ShadyNagy.Blazor.JavaScriptUtilities
```

### 1. Register Services

For Blazor WebAssembly: You will need to add the following using statement and add a call to register the Blazor JavaScript Utilities services in your applications Program.Main method.

```csharp
using ShadyNagy.Blazor.JavaScriptUtilities;

public static async Task Main(string[] args)
{
    builder.Services.AddAllBlazorJavaScriptUtilities();
}
```
Also you can register what you need only ex
```csharp
builder.Services.AddBlazorScrollController();
```

For Blazor Server: You will need to add the following using statement and add a call to register the Blazor JavaScript Utilities services in your applications Startup.ConfigureServices method.
```csharp
using ShadyNagy.Blazor.JavaScriptUtilities;

public void ConfigureServices(IServiceCollection services)
{
    services.AddAllBlazorJavaScriptUtilities();
}
```
Also you can register what you need only ex
```csharp
services.AddBlazorScrollController();
```

### 2. Add reference to style sheet & javascript reference

Add the following line to the `head` tag of your `_Host.cshtml` (Blazor Server) or `index.html` (Blazor WebAssembly).
```html
<link rel="stylesheet" href="_content/ShadyNagy.Blazor.JavaScriptUtilities/blazor-javascript-utilities.min.css" />
```

Then add a reference to the Blazor Utilities JavaScript file at the bottom of the respective page after the reference to the Blazor file before </body>.

```html
<script src="_content/ShadyNagy.Blazor.JavaScriptUtilities/blazor-javascript-utilities-min.js" type="text/javascript" language="javascript"></script>
```

### 3. Add Imports

Add the following to your *_Imports.razor*

```razor
@using ShadyNagy.Blazor.JavaScriptUtilities
@using ShadyNagy.Blazor.JavaScriptUtilities.Services
@using ShadyNagy.Blazor.JavaScriptUtilities.Constants
```

### 4. Add Injects

```razor
@inject IBlazorScrollController BlazorScrollController
@inject IBlazorCookie BlazorCookie
```

### 5. Examples

To hide both scrolls
```csharp
await BlazorScrollController.HideBodyScrollOverflowAsync(ScrollType.Both);
```

## Usage

Please checkout the [sample projects](https://github.com/ShadyNagy/Blazor.JavaScriptUtilities/tree/master/samples/blazor-sample) in this repo to see working examples of the features in the Blazor JavaScript Utilities.

## Registration Functions

| Function | Description |
| --- | --- |
| AddAllBlazorJavaScriptUtilities() | **Register** all services |
| AddBlazorCookie() | **Register** cookie service only |
| AddBlazorScrollController() | **Register** scrollbar controller service only |
| AddBlazorLocalStorage() | **Register** local storage service only |
| AddBlazorSessionStorage() | **Register** session storage service only |
| AddBlazorDialog() | **Register** alert, prompt and confirm only |

## Local Storage Functions

| Function | Description |
| --- | --- |
| Task<bool> IsAvailableAsync() | **Is Available** on this browser *(Async)* |
| Task<bool> SetAsync(string key, string value) | **Set** local storage *(Async)* |
| Task<bool> GetAsync(string key) | **Get** local storage by key *(Async)* |
| Task<int> CountAsync() | **Count** how many local storage *(Async)* |
| Task<bool> RemoveAsync(string key) | **Remove** local storage by key *(Async)* |
| Task<bool> ClearAsync() | **Clear** all local storage *(Async)* |
| Task<Dictionary<string, string>> GetAllAsync() | **Get All** local storage *(Async)* |
| OnChange | **Event** to detect changes at local storage *(Async)* |
| Task AddStorageListenerAsync() | **Add Listener** to detect changes at local storage *(Async)* |
| string GetChangedKey() | **Get Changed Key** if local storage changed *(Async)* |
| ChangedLocalStorage GetChangedLocalStorage() | **Get Changed** will get Key, New Value, Old Value and, URL *(Async)* |
        
## Changed Local Storage Class

| property | Description |
| --- | --- |
| Key | Local Storage Key |
| New Value | Local Storage New Value |
| Old Value | Local Storage Old Value |
| URL | Local Storage URL |

## Cookie Functions

| Function | Description |
| --- | --- |
| Task DeleteCookieAsync(string name) | **Delete** cookie by name *(Async)* |
| Task<string> GetCookieAsync(string name) | **Read** cookie by name *(Async)* |
| void DeleteCookie(string name) | **Delete** cookie by name *(Sync)* |
| string GetCookie(string name) | **Read** cookie by name *(Sync)* |
    
## Dialgo Functions

| Function | Description |
| --- | --- |
| Task ShowAlertAsync(string message) | **Show Alert** with message *(Async)* |
| Task ShowConfirmAsync(string message) | **Show Confirm** with message and return true if click ok *(Async)* |
| Task ShowPromptAsync(string message, string defaultResponse) | **Show Prompt** with message and return user input *(Async)* |

## Scrollbar Controller Functions

| Function | Description |
| --- | --- |
| Task HideScrollOverflowByTagAsync(string tagName, ScrollType scrollType) | **Hide** scrollbar overflow by tag name *(Async)* |
| Task ShowScrollOverflowByTagAsync(string tagName, ScrollType scrollType) | **Show** scrollbar overflow by tag name *(Async)* |
| Task HideScrollOverflowByClassAsync(string tagName, ScrollType scrollType) | **Hide** scrollbar overflow by class name *(Async)* |
| Task ShowScrollOverflowByClassAsync(string tagName, ScrollType scrollType) | **Show** scrollbar overflow by class name *(Async)* |
| Task HideBodyScrollOverflowAsync(ScrollType scrollType) | **Hide** scrollbar overflow from body, it will help in modal *(Async)* |
| Task ShowBodyScrollOverflowAsync(ScrollType scrollType) | **Show** scrollbar overflow from body, it will help in modal  *(Async)* |
| Task<bool> ScrollVToElementByIdAsync(string elementId, string behavior, string block) | **Scroll Verical** to element by id *(Async)* |
| Task<bool> ScrollVToElementByTagAsync(string tagName, string behavior, string block) | **Scroll Verical** to element by tag *(Async)* |
| Task<bool> ScrollVToElementByClassAsync(string className, string behavior, string block) | **Scroll Verical** to element by class name *(Async)* |
| Task<bool> ScrollHToElementByIdAsync(string elementId, string behavior, string inline) | **Scroll Horizontal** to element by id *(Async)* |
| Task<bool> ScrollHToElementByTagAsync(string tagName, string behavior, string inline) | **Scroll Horizontal** to element by tag *(Async)* |
| Task<bool> ScrollHToElementByClassAsync(string className, string behavior, string inline) | **Scroll Horizontal** to element by class name *(Async)* |
| Task<bool> ScrollToBodyAsync(string behavior, string block) | **Scroll Verical** to body *(Async)* |
| Task<bool> ScrollToBodyTopAsync(string behavior) | **Scroll Verical** to top of body *(Async)* |
| Task<bool> ScrollToBodyBottomAsync(string behavior) | **Scroll Verical** to bottom of body *(Async)* |
| Task HideScrollOverflowByTag(string tagName, ScrollType scrollType) | **Hide** scrollbar overflow by tag name *(Sync)* |
| Task ShowScrollOverflowByTag(string tagName, ScrollType scrollType) | **Show** scrollbar overflow by tag name *(Sync)* |
| Task HideScrollOverflowByClass(string tagName, ScrollType scrollType) | **Hide** scrollbar overflow by class name *(Sync)* |
| Task ShowScrollOverflowByClass(string tagName, ScrollType scrollType) | **Show** scrollbar overflow by class name *(Sync)* |
| Task HideBodyScrollOverflow(ScrollType scrollType) | **Hide** scrollbar overflow from body, it will help in modal *(Sync)* |
| Task ShowBodyScrollOverflow(ScrollType scrollType) | **Show** scrollbar overflow from body, it will help in modal  *(Sync)* |

## Scrollbar Types

| Type | Description |
| --- | --- |
| ScrollType.Vertical | **Vertical** scrollbar will be affected |
| ScrollType.Horizontal | **Horizontal** scrollbar will be affected |
| ScrollType.Both | **Vertical & Horizontal** scrollbar will be affected |

## Scrollbar Behaviors

| Type | Description |
| --- | --- |
| ScrollBehaviors.Auto | **Auto** behavior |
| ScrollBehaviors.Smooth | **Smooth** behavior |

## Scrollbar Blocks/Inlines

| Type | Description |
| --- | --- |
| ScrollBlocks.Start | **Start** |
| ScrollBlocks.Center | **Center** |
| ScrollBlocks.End | **End** |
| ScrollBlocks.Nearest | **Nearest** |

## JavaScipt Files **(add to javascript reference)**

| JavaScript File | Description |
| --- | --- |
| blazor-javascript-utilities.js | If **all Javascript** functions are used |
| cookie.js | If **cookie Javascript** functions are used |
| scroll-controller.js | If **scrollbar controller Javascript** functions are used |
| storage.js | If **local/session storage Javascript** functions are used |
| dialog.js | If **alert, prompt and confirm** functions are used |

