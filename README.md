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
Utilities by JavaScript for Blazor (Scroll Hide, Scroll Show, Cookie Read, Cookie Delete, ...... and more comming).

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
<script src="_content/ShadyNagy.Blazor.JavaScriptUtilities/blazor-javascript-utilities-muin.js" type="text/javascript" language="javascript"></script>
```

### 3. Add Imports

Add the following to your *_Imports.razor*

```razor
@using ShadyNagy.Blazor.JavaScriptUtilities
@using ShadyNagy.Blazor.JavaScriptUtilities.Services
```

To hide both scrolls
```csharp
await BlazorScrollController.HideBodyScrollOverflowAsync(ScrollType.Both);
```

## Usage

Please checkout the [sample projects](https://github.com/ShadyNagy/Blazor.JavaScriptUtilities/tree/master/samples/blazor-sample) in this repo to see working examples of the features in the Blazor JavaScript Utilities.


