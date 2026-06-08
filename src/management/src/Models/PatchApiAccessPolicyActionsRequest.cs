namespace MonoCloud.Management.Models;

/// <summary>
/// Patch API Access Policy Actions Request: Used to partially update action settings for an API access policy.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchApiAccessPolicyActionsRequest>))]
public class PatchApiAccessPolicyActionsRequest
{
  /// <summary>
  /// Overrides whether access tokens are issued as self-contained JWTs or opaque reference tokens. When unset, the API resource default is used.
  /// </summary>
  /// <note>ScaleX subscription required to use reference tokens. Reference tokens improve revocation control and reduce token exposure, but require protected resources to use token introspection.</note>
  public Optional<AccessTokenTypes?> AccessTokenType { get; set; }

  /// <summary>
  /// Overrides the access token lifetime (in seconds). When unset, the API resource default is used.
  /// </summary>
  public Optional<int?> AccessTokenLifetime { get; set; }

  /// <summary>
  /// Overrides whether access tokens issued for this resource may include additional audiences. When unset, the API resource default is used.
  /// </summary>
  /// <note>ScaleX subscription required to allow multi-audience tokens.</note>
  public Optional<bool?> AllowMultiAudience { get; set; }

  /// <summary>
  /// Overrides whether access tokens issued for this resource may include identity scopes and be used with identity endpoints such as UserInfo. When unset, the API resource default is used.
  /// </summary>
  /// <note>ScaleX subscription required to allow UserInfo access.</note>
  public Optional<bool?> AllowUserInfoAccess { get; set; }

  /// <summary>
  /// Overrides whether access tokens issued for this resource are bound to the user session and revoked when the session ends. When unset, the API resource default is used.
  /// </summary>
  /// <note>ScaleX subscription required to use session binding.</note>
  public Optional<bool?> BindTokensToSession { get; set; }
}


