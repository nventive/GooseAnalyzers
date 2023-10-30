# GooseAnalyzers

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg?style=flat-square)](LICENSE) ![Version](https://img.shields.io/nuget/v/GooseAnalyzers?style=flat-square) ![Downloads](https://img.shields.io/nuget/dt/GooseAnalyzers?style=flat-square)

GooseAnalyzers is a collection of .NET Analyzers for your C# code.

## Getting Started

1. Install the [`GooseAnalyzers`](https://www.nuget.org/packages/GooseAnalyzers) NuGet package in your project.

1. Optionally, set `TreatWarningsAsErrors` to `true` when in `Release` configuration in your project files.
   ```xml
   <TreatWarningsAsErrors Condition="'$(Configuration)'=='Release'">true</TreatWarningsAsErrors>
   ```
   We recommend this so that you get warnings that don't block your dev loop, but errors that block your CI/CD pipelines.

1. Review the list of analyzers below and adjust your project settings based on your preferences.

## List of Analyzers

Identifier | Name | Description
-|-|-
`GOOSE001` | XmlDocumentationRequiredSuppressor | Limits the scope of [CS1591](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1591) and [SA1600](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1600.md) to interfaces.

## Features

### `GOOSE001` - XML Documentation on Interfaces
The `GOOSE001` analyzer is a `DiagnosticSuppressor` for the [CS1591](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1591) and [SA1600](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1600.md) rules that demand XML documentation on all public types and members.
This is a good practice, but it can unrealistic in some contexts. 
We think that in those cases, having xml documentation on interfaces is a good middle ground.

- If you typically disable the `CS1591` or `SA1600` rules, we recommend that the you enable them and use this suppressor to limit their scope to interfaces.
- If you typically enable the `CS1591` or `SA1600` rules, we recommend that the you disable the `GOOSE001` suppressor.

## Breaking Changes

Please consult [BREAKING_CHANGES.md](BREAKING_CHANGES.md) for more information about version
history and compatibility.

## License

This project is licensed under the Apache 2.0 license - see the
[LICENSE](LICENSE) file for details.

## Contributing

Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on the process for
contributing to this project.

Be mindful of our [Code of Conduct](CODE_OF_CONDUCT.md).