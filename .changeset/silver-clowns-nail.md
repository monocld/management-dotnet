---
"@monocloud/management-dotnet": patch
---

Update management SDK models with consent settings and subscription tier notes

- Add enable_consent field to Application, CreateApplicationRequest, and PatchApplicationRequest
- Document subscription tier requirements (Secure+, Pro, ScaleX) across consent, PAR, channel logout, sign-up restrictions, and removeApplicationFromGroup
- Remove immutable identifier fields from PATCH requests: audience (PatchApiResourceRequest) and name (PatchApiScopeRequest, PatchScopeRequest, PatchClaimResourceRequest)
