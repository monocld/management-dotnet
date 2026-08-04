# @monocloud/management-dotnet

## 0.3.0

### Minor Changes

- 6186020: Exposed the error code the api reports as `ErrorCode` on the exceptions of the statuses that carry one (400, 402, 403, 404, 409), through a new `MonoCloudCodedException` base, typed `ErrorCode` and `TraceId` on `ProblemDetails`, and added an overridable `ThrowProblem` seam to `MonoCloudClientBase` so an sdk can throw its own exception for the errors its api declares

## 0.2.11

### Patch Changes

- e3f1d1c: Updated SDKs to latest APIs

## 0.2.10

### Patch Changes

- 04835d6: Updated SDKs to latest APIs

## 0.2.9

### Patch Changes

- 457b361: Updated to the latest API version

## 0.2.8

### Patch Changes

- b9841f2: - Add network zones, API access policies, and S3 trust store sources to management SDK

## 0.2.7

### Patch Changes

- af6b00f: Fix timeout assignment to use TotalSeconds in MonoCloudManagementServiceExtensions

## 0.2.6

### Patch Changes

- ff7884d: Update management SDK models with consent settings and subscription tier notes

  - Add enable_consent field to Application, CreateApplicationRequest, and PatchApplicationRequest
  - Document subscription tier requirements (Secure+, Pro, ScaleX) across consent, PAR, channel logout, sign-up restrictions, and removeApplicationFromGroup
  - Remove immutable identifier fields from PATCH requests: audience (PatchApiResourceRequest) and name (PatchApiScopeRequest, PatchScopeRequest, PatchClaimResourceRequest)

## 0.2.5

### Patch Changes

- 398ffd8: Refactored clients API

## 0.2.4

### Patch Changes

- beb783b: Add change password endpoint

## 0.2.3

### Patch Changes

- e70f7f0: - Refactor terminology: replace 'blacklist' with 'blocklist' and 'whitelist' with 'allowlist'
  - Added 'UsageThresholdReached' event code
  - Added IsSessionBound property

## 0.2.2

### Patch Changes

- d5a6cd0: Fix NuGet package readme and update dependency versions

  - Updated NuGet Readme to only include banner.
  - Added NuGet Readme back to Management SDK.
  - Bumped dependency versions.

## 0.2.1

### Patch Changes

- 7f9bbeb: Combined Admin and Identity SDK

## 0.2.0

### Minor Changes

- c7ac499: Removed External Dependency (Macross.Json.Extensions)

### Patch Changes

- baaf0f9: Admin - Added New Fields
- b4d2fe1: Identity - Added New Fields
  Identity - Updated Descriptions

## 0.1.1

### Patch Changes

- e2f503a: Changed Repository Url and Regenerated Docs
