# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

A .NET 10 console application (`Coding/`) with GitHub Actions workflows for Claude Code integration.

## Commands

```bash
# Build
dotnet build Coding/Coding.csproj

# Run
dotnet run --project Coding/Coding.csproj

# Build solution
dotnet build helloclaude2026.sln
```

## Architecture

Single-project .NET 10 console app (`Coding/Program.cs`) using top-level statements. No tests, no external dependencies.

`appsettings.json` is present but not yet wired up — the app uses no configuration host. The `DataBase_URL` field is a placeholder; never commit real credentials there.

## GitHub Actions

Two Claude Code workflows in `.github/workflows/`:

- **`claude.yml`** — triggers on `@claude` mentions in issues/PRs/comments; runs `claude-code-action@v1` to perform whatever the comment requests.
- **`claude-code-review.yml`** — runs `/code-review --comment` on every PR, posting inline review comments via the GitHub MCP tool.

Both require `CLAUDE_CODE_OAUTH_TOKEN` in repository secrets.
