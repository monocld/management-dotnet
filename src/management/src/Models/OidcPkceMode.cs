namespace MonoCloud.Management.Models;

/// <summary>
/// The PKCE mode used with an external OIDC provider.
/// </summary>
public enum OidcPkceMode
{
  /// <summary>
  /// PKCE is negotiated automatically based on the provider's discovery metadata.
  /// </summary>
  Auto,

  /// <summary>
  /// PKCE using the S256 code challenge method.
  /// </summary>
  S256,

  /// <summary>
  /// PKCE using the plain code challenge method.
  /// </summary>
  Plain,

  /// <summary>
  /// PKCE is disabled.
  /// </summary>
  None
}


