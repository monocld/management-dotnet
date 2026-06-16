# AGENTS.md — `MonoCloud.Management.Core`

Scope: `src/core`. Read the repo-root [AGENTS.md](../../AGENTS.md) first for build/style/release basics.

## What this project is

The shared, **hand-written** plumbing that every MonoCloud .NET Management SDK is built on: HTTP dispatch, JSON (de)serialization, the response envelope, the exception hierarchy, and the PATCH/`Optional<T>` machinery. Package id `MonoCloud.Management.Core`; root namespace `MonoCloud.Management.Core`.

Unlike `src/management`'s `Models/` and `Clients/`, **this project is not generated** — edit it directly and carefully, since changes here affect the entire SDK surface.

## Layout

```
Base/
  MonoCloudClientBase.cs   → base class for every resource client: ProcessRequestAsync + JSON settings
  MonoCloudConfig.cs       → Domain/ApiKey/Timeout; sanitizes the domain URL
  MonoCloudResponse.cs     → response envelope (Status, Headers, Data, PageData)
Exception/
  MonoCloud*Exception.cs   → typed exception per HTTP status; MonoCloudException.ThrowErr maps status → type
  ValidationExceptionTypes.cs
Helpers/
  Optional.cs / IOptional.cs   → the PATCH "was this field set?" marker
  PatchConverter.cs            → System.Text.Json converter that serializes only set Optional<T> fields
  EpochDateTime(Nullable)Converter.cs → unix-seconds <-> DateTime
  SnakeCaseNamingPolicy.cs     → snake_case property + enum naming
  PageModel.cs                 → pagination metadata (from the x-pagination header)
Models/
  ProblemDetails.cs, IdentityError.cs, *ProblemDetails.cs → RFC7807 error bodies
```

## Key types and how they fit together

- **`MonoCloudClientBase`** — base for all resource clients. Owns a single static `JsonSerializerOptions` (snake_case naming policy, snake_case enum converter, epoch datetime converters, `WhenWritingNull`). All HTTP goes through its three `ProcessRequestAsync` overloads: no-body, `<TResult>`, and `<TResult, TPage>` (paginated, reads the `x-pagination` header into `PageModel`). Non-2xx responses are routed to `MonoCloudException.ThrowErr`. Auth is the `X-API-KEY` header; base address is `{domain}/api/`.
- **`MonoCloudResponse` / `<T>` / `<T, TPage>`** — the envelope. Body is **`Data`**, status is **`Status`** (int), headers are `IDictionary<string, IEnumerable<string>>`. Keep these names — consumers and the skill depend on them.
- **`Optional<T>` + `PatchConverter<T>`** — the PATCH mechanism. A `Patch*` request model marks fields `Optional<T>` and carries `[JsonConverter(typeof(PatchConverter<T>))]`; the converter serializes only fields where `HasValue` is true, so "not set" is omitted and an explicitly-set `null` is sent (remove semantics). Don't replace this with plain nullable properties.
- **Exceptions** — `MonoCloudException` is the base; `MonoCloudRequestException` exposes `.Response` (`ProblemDetails?`). `ThrowErr` maps status → subclass: the `ProblemDetails` overload fans 422 out to identity-validation vs key-validation by the problem `type`, while model-state (`MonoCloudModelStateException`) comes from the status-code overload used when the body isn't `application/problem+json`. There is intentionally **no** `StatusCode` property.

## Constraints when editing

- **Multi-targets `net462;netstandard2.0`.** Code must compile on `netstandard2.0` — no `net6+`-only APIs, no `System.Text.Json` features newer than the referenced version. `Microsoft.Bcl.HashCode` is referenced precisely because `HashCode` isn't in netstandard2.0.
- Consumers and `src/management` reach core types through **global usings** (e.g. `using MonoCloud.Management.Core.Base;`), not project references they add themselves. Keep public namespaces stable.
- Match the existing 2-space / Allman / file-scoped-namespace style; run `dotnet format` before committing.
