namespace MonoCloud.Management.Models;

/// <summary>
/// Patch API Resource Request: Used to update one or more properties of an existing API resource.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchApiResourceRequest>))]
public class PatchApiResourceRequest
{
  /// <summary>
  /// Indicates whether the resource is enabled.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Human-readable display name for the resource.
  /// </summary>
  public Optional<string?> DisplayName { get; set; }

  /// <summary>
  /// Description that explains the purpose of the resource.
  /// </summary>
  public Optional<string?> Description { get; set; }

  /// <summary>
  /// Specifies whether access tokens issued for this resource may carry additional audiences beyond this resource.
  /// </summary>
  /// <note>ScaleX subscription required to allow multi-audience tokens.</note>
  public Optional<bool> AllowMultiAudience { get; set; }

  /// <summary>
  /// Specifies whether access tokens issued for this resource may include identity scopes, allowing them to be used with identity-related endpoints such as &#x60;UserInfo&#x60;.
  /// </summary>
  /// <note>ScaleX subscription required to allow UserInfo access.</note>
  public Optional<bool> AllowUserInfoAccess { get; set; }

  /// <summary>
  /// List of user claim types that will be embedded into access tokens issued for this API resource.
  /// </summary>
  public Optional<List<string>> UserClaims { get; set; }

  /// <summary>
  /// Default access token type for this API resource. Used when no matching API access policy provides an override.
  /// </summary>
  /// <note>ScaleX subscription required to use reference tokens. Reference tokens improve revocation control and reduce exposure risk, but require token introspection by protected resources.</note>
  public Optional<AccessTokenTypes> AccessTokenType { get; set; }

  /// <summary>
  /// Default access token lifetime (in seconds) for this API resource. Used when no matching API access policy provides an override.
  /// </summary>
  public Optional<int> AccessTokenLifetime { get; set; }

  /// <summary>
  /// Default value for whether access tokens issued for this API resource are bound to the user session, causing them to be revoked when the session ends. Used when no matching API access policy provides an override.
  /// </summary>
  /// <note>ScaleX subscription required to use session binding.</note>
  public Optional<bool> BindTokensToSession { get; set; }

  /// <summary>
  /// Determines whether access tokens issued for this API resource include a unique token identifier (jti).
  /// </summary>
  /// <note>Recommended for auditing, correlation, and replay-detection.</note>
  public Optional<bool> IncludeJwtId { get; set; }
}


