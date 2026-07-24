# AGENTS.md

Guidance for AI coding agents working on this repository. Human contributors may find it useful too.

## What this repo is

`management-dotnet` is the **MonoCloud Management SDK for .NET** — a typed client for the MonoCloud Management API used to programmatically manage applications, users, groups, API resources, sign-in options, branding, logs, keys, trust stores, and network zones.

It ships as two NuGet packages:

| Package                     | Project          | Role                                                                 |
| --------------------------- | ---------------- | -------------------------------------------------------------------- |
| `MonoCloud.Management`      | `src/management` | The public SDK consumers install.                                    |
| `MonoCloud.Management.Core` | `src/core`       | Shared HTTP/serialization/exception plumbing the SDK is built on.    |

> This repo *produces* the SDK. For guidance on *consuming* it in an application, see the `monocloud-management-dotnet` skill in [monocloud/agent-skills](https://github.com/monocloud/agent-skills) — don't duplicate consumer docs here.

## Repository layout

```
src/
  core/                 → MonoCloud.Management.Core (hand-written plumbing). See src/core/AGENTS.md
  management/
    src/                → MonoCloud.Management (public SDK).      See src/management/AGENTS.md
    tests/              → xunit unit tests (net10.0)
  Directory.Packages.props   → central package versions + shared MSBuild props (incl. <Version>)
Management.slnx         → solution file
global.json            → pins the .NET SDK (10.0.0, rollForward latestMajor)
docs/ , docs-gen/      → DocFX API reference (generated)
.changeset/            → Changesets release config
package.json           → pnpm scripts for changesets + docs only (no app code)
```

## Generated vs hand-written — read before editing `src/management`

The bulk of `src/management/src/Models/*.cs` and `src/management/src/Clients/*.cs` is **generated from the MonoCloud Management API specification**, and is maintained upstream rather than by hand in this repo.

Implications:
- Treat `Models/` and `Clients/` as generated artifacts. Hand-edits there risk being overwritten on the next regeneration — prefer fixing the upstream spec/generator.
- The **hand-written** surface is: everything in `src/core`, plus `MonoCloudManagementClient.cs`, `MonoCloudManagementServiceExtensions.cs`, `MonoCloudManagementOptions.cs`, `GlobalUsings.cs`, and the tests.
- Naming that looks "wrong" usually mirrors the API spec and must **not** be "corrected": file `UsersApi.cs` defines class `UsersClient`; the `.Clients` property exposes `*Application*` methods.

## Common commands

```bash
dotnet restore
dotnet build  --configuration Release            # builds all 3 projects
dotnet test   src/management/tests/MonoCloud.Management.UnitTests/MonoCloud.Management.UnitTests.csproj --configuration Release
dotnet format --verify-no-changes                # lint; CI fails if this reports changes
pnpm install && pnpm gen:docs                    # regenerate DocFX reference into docs/ (requires the `docfx` tool)
```

All of the above are green on a clean checkout. CI (`.github/workflows/build.yaml`) runs build → `dotnet format --verify-no-changes` → test; **run `dotnet format` before committing** or the lint job fails.

## Toolchain & target frameworks

- **.NET SDK 10** (`global.json`), but the shipping libraries multi-target **`net462;netstandard2.0`**. Any code you add to `src/core` or `src/management/src` must compile on `netstandard2.0` — no .NET-only or modern-only BCL APIs. The test project targets `net10.0`.
- **Central Package Management** (`src/Directory.Packages.props`, `ManagePackageVersionsCentrally=true`): add/bump dependency versions there with `<PackageVersion>`, reference them in `.csproj` with a bare `<PackageReference Include="..." />` (no `Version`).
- `LangVersion=14.0`, `Nullable=enable`, `SignAssembly=true`, `GenerateDocumentationFile=true` (CS1591/CS8618 suppressed). These are set once in `Directory.Packages.props`.

## Code style

Enforced by `.editorconfig` + `dotnet format`:
- **2-space indentation**, LF line endings, UTF-8, final newline.
- **Allman braces** (`csharp_brace_style = next_line`).
- **File-scoped namespaces** (`namespace Foo;`).
- Per-project `GlobalUsings.cs` declares common `using`s — don't add redundant per-file usings for things already global there.
- XML doc comments on public members.

## Versioning & release (Changesets)

- Every user-facing change needs a changeset: `pnpm changeset` (or hand-write a file in `.changeset/`).
- Merging to `main` opens/updates a `changeset-release/main` PR. Merging **that** PR bumps the version, syncs `<Version>` in `src/Directory.Packages.props` (via `.github/scripts/update-version.sh`), publishes to NuGet, and tags a GitHub release.
- Commenting `!snapshot` on a PR (by a user with write access) publishes a canary build to NuGet.org.
- Don't bump `<Version>` by hand — the release pipeline owns it.

## Where to look next

- `src/core/AGENTS.md` — the plumbing layer (what you actually edit by hand).
- `src/management/AGENTS.md` — the public SDK: client/model conventions, adding endpoints, tests.
