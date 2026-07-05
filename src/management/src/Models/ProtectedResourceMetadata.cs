namespace MonoCloud.Management.Models;

/// <summary>
/// OAuth 2.0 Protected Resource Metadata (RFC 9728) configuration for an API resource. These settings drive the &#x60;/.well-known/oauth-protected-resource&#x60; document that the resource server hosts on its own origin, and the resource identifier advertised in the authorization server&#39;s &#x60;protected_resources&#x60; metadata.
/// </summary>
public class ProtectedResourceMetadata
{
  /// <summary>
  /// Enables Protected Resource Metadata for this API resource. When enabled, a metadata document can be generated for the resource server to host and the resource identifier can be advertised by the authorization server.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Human-readable name of the protected resource (RFC 9728 &#x60;resource_name&#x60;), displayed to end users during authorization.
  /// </summary>
  public string? ResourceName { get; set; }

  /// <summary>
  /// Localized human-readable names of the protected resource, keyed by language tag. Each entry is emitted as a language-tagged &#x60;resource_name#&amp;lt;lang&amp;gt;&#x60; field (RFC 9728 §2) alongside the default &#x60;resource_name&#x60;.
  /// </summary>
  public object? ResourceNameTranslations { get; set; }

  /// <summary>
  /// URL of human-readable documentation for developers using the protected resource (RFC 9728 &#x60;resource_documentation&#x60;).
  /// </summary>
  public string? ResourceDocumentation { get; set; }

  /// <summary>
  /// URL of a page describing the protected resource&#39;s data-usage policy (RFC 9728 &#x60;resource_policy_uri&#x60;).
  /// </summary>
  public string? ResourcePolicyUri { get; set; }

  /// <summary>
  /// URL of the protected resource&#39;s terms of service (RFC 9728 &#x60;resource_tos_uri&#x60;).
  /// </summary>
  public string? ResourceTosUri { get; set; }

  /// <summary>
  /// URL of the protected resource&#39;s own JWK Set, used when the resource signs its responses (RFC 9728 &#x60;jwks_uri&#x60;). This is distinct from the authorization server&#39;s JWKS.
  /// </summary>
  public string? JwksUri { get; set; }

  /// <summary>
  /// The methods the protected resource supports for receiving bearer access tokens (RFC 9728 &#x60;bearer_methods_supported&#x60;). Defaults to the &#x60;Authorization&#x60; header, which is the recommended method.
  /// </summary>
  public List<BearerMethods> BearerMethodsSupported { get; set; }

  /// <summary>
  /// JWS algorithms the protected resource uses to sign its responses (RFC 9728 &#x60;resource_signing_alg_values_supported&#x60;). The value &#x60;none&#x60; is never permitted.
  /// </summary>
  public List<SigningAlgorithms> ResourceSigningAlgValuesSupported { get; set; }

  /// <summary>
  /// Authorization details type identifiers the protected resource supports (RFC 9396 / RFC 9728 &#x60;authorization_details_types_supported&#x60;).
  /// </summary>
  public List<string> AuthorizationDetailsTypesSupported { get; set; }

  /// <summary>
  /// Indicates whether the protected resource requires DPoP-bound access tokens (RFC 9449 &#x60;dpop_bound_access_tokens_required&#x60;). When unset, the field is omitted from the generated metadata document.
  /// </summary>
  /// <note>DPoP enforcement is configured per client; this advertises the resource's requirement to clients.</note>
  public bool? DpopBoundAccessTokensRequired { get; set; }

  /// <summary>
  /// JWS algorithms the protected resource accepts for DPoP proofs (RFC 9449 &#x60;dpop_signing_alg_values_supported&#x60;).
  /// </summary>
  public List<SigningAlgorithms> DpopSigningAlgValuesSupported { get; set; }

  /// <summary>
  /// Optional custom well-known path suffix at which the resource hosts its metadata document. Defaults to &#x60;oauth-protected-resource&#x60; when unset.
  /// </summary>
  public string? WellKnownSuffix { get; set; }

  /// <summary>
  /// Suggested &#x60;Cache-Control&#x60; max-age (in seconds) for the hosted metadata document (RFC 9728 §7.10).
  /// </summary>
  public int? CacheMaxAge { get; set; }

  /// <summary>
  /// Indicates whether the generated metadata document should additionally be issued as a signed JWS (RFC 9728 &#x60;signed_metadata&#x60;), using the tenant&#39;s signing key.
  /// </summary>
  /// <note>Signed metadata generation is not yet available and this flag is reserved for a future release.</note>
  public bool SignedMetadataEnabled { get; set; }
}


