# LowerCaseSwaggerDocumentPaths
Generate lower case Swagger document paths in ASP.NET Core.

## Getting started
1. Install the NuGet package into your ASP.NET Core application.

```
Install-Package LowerCaseSwaggerDocumentPaths
```

2. Register LowerCaseSwaggerDocumentPaths in the _ConfigureServices_ method of _Startup.cs_.

```csharp
services.AddSwaggerGen(options =>
{
	options.LowerCasePaths();

	// ...
});
```
