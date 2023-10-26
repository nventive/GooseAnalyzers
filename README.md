# GooseAnalyzers

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg?style=flat-square)](LICENSE)

GooseAnalyzers is a collection of .NET Analyzers for your C# code.

## Getting Started

1. Install the `GooseAnalyzers` NuGet package in your project.

1. Optionally, set `TreatWarningsAsErrors` to `true` when in `Release` configuration in your project files.
   ```xml
   <TreatWarningsAsErrors Condition="'$(Configuration)'=='Release'">true</TreatWarningsAsErrors>
   ```
   We recommend this so that you get warnings that don't block your dev loop, but errors that block your CI/CD pipelines.

## Features

TODO

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