namespace MonoCloud.Management.Models;

/// <summary>
/// API Access Policy Actions Response: Represents the action settings applied when an API access policy rule matches.
/// </summary>
public class ApiAccessPolicyActions
{
  /// <summary>
  /// Overrides whether access tokens are issued as self-contained JWTs or opaque reference tokens. When unset, the API resource default is used.
  /// </summary>
  public AccessTokenTypes? AccessTokenType { get; set; }

  /// <summary>
  /// Overrides the access token lifetime (in seconds). When unset, the API resource default is used.
  /// </summary>
  public int? AccessTokenLifetime { get; set; }

  /// <summary>
  /// Overrides whether access tokens issued for this resource may include additional audiences. When unset, the API resource default is used.
  /// </summary>
  /// <note>ScaleX subscription required to allow multi-audience tokens.</note>
  public bool? AllowMultiAudience { get; set; }

  /// <summary>
  /// Overrides whether access tokens issued for this resource may include identity scopes and be used with identity endpoints such as UserInfo. When unset, the API resource default is used.
  /// </summary>
  /// <note>ScaleX subscription required to allow UserInfo access.</note>
  public bool? AllowUserInfoAccess { get; set; }

  /// <summary>
  /// Overrides whether access tokens issued for this resource are bound to the user session and revoked when the session ends. When unset, the API resource default is used.
  /// </summary>
  /// <note>ScaleX subscription required to use session binding.</note>
  public bool? BindTokensToSession { get; set; }
}


