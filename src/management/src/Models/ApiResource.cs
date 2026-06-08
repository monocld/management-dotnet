namespace MonoCloud.Management.Models;

/// <summary>
/// API Resource Response: Represents a protected API resource and its access-token issuance configuration.
/// </summary>
public class ApiResource
{
  /// <summary>
  /// The unique identifier of the resource.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Indicates whether the resource is enabled.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Human-readable display name for the resource.
  /// </summary>
  public string? DisplayName { get; set; }

  /// <summary>
  /// Description that explains the purpose of the resource.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Specifies the creation time of the resource (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the resource (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// Audience value that will be included in issued access tokens for this API resource.
  /// </summary>
  public string Audience { get; set; }

  /// <summary>
  /// Default value for whether access tokens issued for this API resource may carry additional audiences beyond this resource. Used when no matching API access policy provides an override.
  /// </summary>
  /// <note>ScaleX subscription required to allow multi-audience tokens.</note>
  public bool AllowMultiAudience { get; set; }

  /// <summary>
  /// Default value for whether access tokens issued for this API resource may include identity scopes, allowing them to be used with identity-related endpoints such as &#x60;UserInfo&#x60;. Used when no matching API access policy provides an override.
  /// </summary>
  /// <note>ScaleX subscription required to allow UserInfo access.</note>
  public bool AllowUserInfoAccess { get; set; }

  /// <summary>
  /// Default access token type for this API resource. Used when no matching API access policy provides an override.
  /// </summary>
  public AccessTokenTypes AccessTokenType { get; set; }

  /// <summary>
  /// Default access token lifetime (in seconds) for this API resource. Used when no matching API access policy provides an override.
  /// </summary>
  public int AccessTokenLifetime { get; set; }

  /// <summary>
  /// Default value for whether access tokens issued for this API resource are bound to the user session, causing them to be revoked when the session ends. Used when no matching API access policy provides an override.
  /// </summary>
  /// <note>ScaleX subscription required to use session binding.</note>
  public bool BindTokensToSession { get; set; }

  /// <summary>
  /// Determines whether access tokens issued for this API resource include a unique token identifier (jti).
  /// </summary>
  /// <note>Recommended for auditing, correlation, and replay-detection.</note>
  public bool IncludeJwtId { get; set; }

  /// <summary>
  /// List of user claim types that will be embedded into access tokens issued for this API resource.
  /// </summary>
  public List<string> UserClaims { get; set; }
}


