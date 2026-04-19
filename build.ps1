$ErrorActionPreference = "Stop"

Write-Host "=== Restoring packages ===" -ForegroundColor Cyan
dotnet restore

Write-Host "=== Linting (StyleCop via build) ===" -ForegroundColor Cyan
dotnet build --configuration Debug --no-restore

Write-Host "=== Building Debug ===" -ForegroundColor Cyan
dotnet build --configuration Debug --no-restore

Write-Host "=== Building Release ===" -ForegroundColor Cyan
dotnet build --configuration Release --no-restore

Write-Host "=== Running Tests ===" -ForegroundColor Cyan
dotnet test --no-build --configuration Release

Write-Host "=== Generating Docs ===" -ForegroundColor Cyan
dotnet tool install -g docfx 2>$null
docfx docs/docfx.json

Write-Host "=== Done ===" -ForegroundColor Green
