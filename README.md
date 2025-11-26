# At.Matus.MetaData.Abstractions

A small, focused abstraction for storing and exposing simple metadata as a single record. The metadata record is represented as a `Dictionary<string, string>` that holds all key/value entries.

## Key concepts

- `Records` — a single `Dictionary<string, string>` containing all metadata entries.
- `RecordCount` — the number of metadata entries (number of key/value pairs in `Records`).
- `AddRecord(string key, string value)` — adds or updates a metadata entry; concrete implementations should document duplicate-key behavior (commonly overwrite).

## Why this package

Keeps metadata concerns separated from domain logic and enables different implementations (in-memory, persisted, adapters) while preserving a minimal surface area.

## Target platform

- .NET Framework 4.7.2
- C# 7.3

## Usage

Consume the interface in code or implement it for your storage needs. Example usage:

Implementers should document:
- Whether `AddRecord` overwrites existing values or behaves differently.
- Whether `Records` returns a live mutable reference or a defensive/read-only copy.
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

