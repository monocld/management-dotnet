# AGENTS.md — `MonoCloud.Management`

Scope: `src/management`. Read the repo-root [AGENTS.md](../../AGENTS.md) and [src/core/AGENTS.md](../core/AGENTS.md) first.

## What this project is

The **public SDK** consumers install (`MonoCloud.Management`). Root namespace `MonoCloud.Management`. It composes the resource clients into one entry point and wires up DI. Built on `MonoCloud.Management.Core` (project reference).

## Layout

```
src/
  MonoCloudManagementClient.cs            → entry point; one property per resource client (hand-written)
  MonoCloudManagementServiceExtensions.cs → AddMonoCloudManagementClient DI extension (hand-written)
  MonoCloudManagementOptions.cs           → Domain/ApiKey/Timeout options (hand-written)
  GlobalUsings.cs                         → shared usings (hand-written)
  Clients/*.cs                            → one *Client per resource area     (GENERATED — see below)
  Models/*.cs                             → request/response/enum types        (GENERATED — see below)
tests/MonoCloud.Management.UnitTests/     → xunit (net10.0)
```

## Generated code — handle with care

`Clients/*.cs` and `Models/*.cs` are **generated from the MonoCloud Management API spec** and maintained upstream — not by hand in this repo.

- Don't hand-tune these for style/naming — changes get overwritten on regen. Fix the upstream spec/generator instead.
- Naming mirrors the API and is intentional: file `UsersApi.cs` → class `UsersClient`; `.Clients` property exposes `*Application*` methods; `User.UserId` (not `Id`). Don't "fix" these.
- The genuinely hand-written, safe-to-edit files are the four `src/*.cs` listed above and the tests.

## Conventions (so generated and hand-written code stay consistent)

- Every resource client extends `MonoCloudClientBase` and offers two ctors: `(MonoCloudConfig)` and `(HttpClient)`.
- Methods are async and return `Task<MonoCloudResponse<T>>`, or `Task<MonoCloudResponse<T, PageModel>>` for paginated lists, and take a trailing `CancellationToken`.
- List methods share the `(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken)` shape.
- `Create*`/full-update requests serialize set fields only via the JSON null-ignore policy; `Patch*` requests use `Optional<T>` + `[JsonConverter(typeof(PatchConverter<…>))]` for merge semantics (see [src/core/AGENTS.md](../core/AGENTS.md)).

## Wiring a new resource client

If a new `Clients/<Area>Api.cs` (class `<Area>Client`) appears, it must be hooked into `MonoCloudManagementClient.cs`: add a public `<Area>Client <Area> { get; }` property and initialize it in **both** constructors (`MonoCloudConfig` and `HttpClient`). Add the client/model namespaces to `GlobalUsings.cs` if needed. Keep the property list alphabetical, matching the existing order.

## DI extension behavior

`AddMonoCloudManagementClient` reads the `MonoCloud:Management` configuration section (`Domain`, `ApiKey`, `Timeout` in **seconds**), lets an `Action<MonoCloudManagementOptions>` override those values, throws `ArgumentNullException` if `Domain`/`ApiKey` are missing, and registers the client as **transient** over a named `IHttpClientFactory` client (`"MonoCloudManagementClient"`). Timeout flows through `TimeSpan.FromSeconds` — keep seconds-vs-ms straight (this was the 0.2.7 fix).

## Tests

- xunit + `Moq.Contrib.HttpClient`, targeting `net10.0`. Run:
  ```bash
  dotnet test tests/MonoCloud.Management.UnitTests/MonoCloud.Management.UnitTests.csproj --configuration Release
  ```
- `SDKTests` builds a `MonoCloudManagementClient(HttpClient)` over a mocked `HttpMessageHandler`. `SetMockResponse(...)` captures the outgoing request body into `_requestMessage` and returns a JSON response. Use it to assert serialization behavior (e.g. "Create only sends set fields", "Patch sends explicit null", enum/list casing, epoch datetime round-trips, `x-pagination` parsing, typed exception mapping). Add tests for new serialization/error behavior in this style.

## Subscription-tier gotchas

Many endpoints and request fields work only on certain MonoCloud plans and return `MonoCloudForbiddenException` otherwise. The generated code annotates these with `<note>…subscription…</note>` XML comments — **those notes are the source of truth; check them rather than trusting a hand-maintained list.** Examples:

- **ScaleX** — all `NetworkZones` endpoints, group↔application assignment (`AssignGroupToApplication` / `RemoveGroupFromApplication`), API-secret creation, and feature fields such as session binding, multi-audience tokens, reference tokens, and extended refresh-token lifetimes.
- **Secure+** — consents (`EnableConsent` on `Application`/`Create`/`Patch` requests), PAR, JAR, back-channel logout, and the `Users` grant/token-management endpoints.
