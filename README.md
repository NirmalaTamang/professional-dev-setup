# professional-dev-setup

A C# console application with a full professional toolchain - linting, static analysis, documentation generation, automated builds, unit testing, and CI/CD.

## Tooling

- **StyleCop Analyzers** — enforces consistent code style and formatting on every build
- **FxCop / Roslyn Analyzers** — catches bugs and bad practices at compile time
- **DocFX** — generates API documentation from XML comments (public members only)
- **xUnit** — unit test suite covering happy path, edge cases, and exceptions
- **GitHub Actions** — runs the full pipeline on every push
- **EditorConfig** — consistent formatting across all editors
- **PowerShell build script** — single command to run the entire pipeline locally

## Stack

- C# / .NET 10
- xUnit
- DocFX
- GitHub Actions
- PowerShell

## Running Locally

```powershell
# Run the app
dotnet run --project src\HelloWorld\HelloWorld.csproj

# Run tests
dotnet test tests\HelloWorld.Tests\HelloWorld.Tests.csproj

# Full build pipeline
.\build.ps1
```

## Project Structure

```
professional-dev-setup/
├── src/HelloWorld/         # Application source
├── tests/HelloWorld.Tests/ # Unit tests
├── docs/                   # DocFX config
├── .github/workflows/      # CI/CD pipeline
├── .editorconfig           # Editor formatting rules
├── stylecop.json           # StyleCop configuration
└── build.ps1               # Build script
```

## CI/CD

Every push triggers GitHub Actions to:
1. Run StyleCop
2. Build Debug and Release
3. Run static analysis
4. Generate documentation
5. Run all unit tests
