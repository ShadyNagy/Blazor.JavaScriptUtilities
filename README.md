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

## How To Use
```powershell
Install-Package ShadyNagy.Blazor.JavaScriptUtilities
```

In program you need to inject the library in Main.cs
```csharp
builder.Services.AddAllBlazorJavaScriptUtilities();
```
Also you can inject what you need only ex
```csharp
builder.Services.AddBlazorScrollController();
```



