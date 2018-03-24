# LowerCaseSwaggerDocumentPaths
Generate lower case Swagger document paths in ASP.NET Core.

## Getting started
Install the NuGet package into your ASP.NET Core application.

### Package Manager
```
Install-Package LowerCaseSwaggerDocumentPaths
```

### .NET CLI
```
dotnet add package LowerCaseSwaggerDocumentPaths
```

## Usage
Register LowerCaseSwaggerDocumentPaths in the _ConfigureServices_ method of _Startup.cs_.

```csharp
services.AddSwaggerGen(options =>
{
	options.LowerCasePaths();

	// ...
});
```
