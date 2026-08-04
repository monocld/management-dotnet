---
"@monocloud/management-dotnet": minor
---

Exposed the error code the api reports as `ErrorCode` on the exceptions of the statuses that carry one (400, 402, 403, 404, 409), through a new `MonoCloudCodedException` base, typed `ErrorCode` and `TraceId` on `ProblemDetails`, and added an overridable `ThrowProblem` seam to `MonoCloudClientBase` so an sdk can throw its own exception for the errors its api declares
