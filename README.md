# At.Matus.MetaData.Abstractions

A small, focused abstraction for storing and exposing simple metadata as a collection of records. Each record is a map (dictionary) of string key/value pairs.

## Key concepts

- `Records` — an array of dictionaries where each element represents a logical metadata record.
- `RecordCount` — the number of records stored.
- `AddRecord(string key, string value)` — add a key/value pair; concrete implementations decide how records are created and how duplicate keys are handled.

## Why this package

This abstraction keeps metadata concerns separated from domain logic and enables multiple implementations (in-memory, persisted, adapter for other metadata stores) while preserving a simple surface area.

## Target platform

- .NET Framework 4.7.2
- C# 7.3

## Usage

Consume the interface in code or implement it for your storage needs. Example usage:

Implementers should document:
- How `AddRecord` determines which record receives the key/value pair.
- Behavior when a duplicate key is added.
- Thread-safety guarantees (if any).

## Building and publishing

- Open the solution in Visual Studio 2022.
- Build via the __Build__ menu or __Solution Explorer__ context.
- To create a NuGet package either:
  - Use an SDK-style project and `dotnet pack`, or
  - Use `nuget.exe pack` / Visual Studio packaging workflows for legacy projects.
- When publishing to GitHub:
  - Create a repository, add this project, push, tag a release, and create a release in GitHub.
  - Optionally publish the NuGet package to nuget.org.

Tip: Use the __Package Manager Console__ in Visual Studio to run package/publish commands if needed.

## Contributing

- Open an issue for feature requests or bugs.
- Send pull requests with focused changes and unit tests where applicable.
- Include a short explanation of API/behavior changes in the PR description.

## License

Add a LICENSE file at the repository root (e.g., MIT, Apache-2.0) according to your project's licensing policy.
