namespace MonoCloud.Management.Models;

/// <summary>
/// Create External Authenticator Connection Request: The protocol connection settings used to communicate with the external identity provider.
/// </summary>
public class CreateExternalAuthenticatorConnectionRequest
{
  /// <summary>
  /// The discovery (metadata) endpoint of the external provider. When set, the provider endpoints are derived from the discovery document.
  /// </summary>
  public string? DiscoveryUrl { get; set; }

  /// <summary>
  /// The authorization endpoint of the external provider. Required when no discovery endpoint is set.
  /// </summary>
  public string? AuthorizeUrl { get; set; }

  /// <summary>
  /// The token endpoint of the external provider. Required when no discovery endpoint is set.
  /// </summary>
  public string? TokenUrl { get; set; }

  /// <summary>
  /// The user info endpoint of the external provider.
  /// </summary>
  public string? UserInfoUrl { get; set; }

  /// <summary>
  /// The PKCE mode used with the external provider.
  /// </summary>
  public OidcPkceMode? PkceMode { get; set; }
}


