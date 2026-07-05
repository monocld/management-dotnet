namespace MonoCloud.Management.Models;

/// <summary>
/// Patch External Authenticator Connection Request: Used to update connection settings used by an external authenticator.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchExternalAuthenticatorConnectionRequest>))]
public class PatchExternalAuthenticatorConnectionRequest
{
  /// <summary>
  /// The discovery (metadata) endpoint of the external provider. When set, the provider endpoints are derived from the discovery document.
  /// </summary>
  public Optional<string?> DiscoveryUrl { get; set; }

  /// <summary>
  /// The authorization endpoint of the external provider. Required when no discovery endpoint is set.
  /// </summary>
  public Optional<string?> AuthorizeUrl { get; set; }

  /// <summary>
  /// The token endpoint of the external provider. Required when no discovery endpoint is set.
  /// </summary>
  public Optional<string?> TokenUrl { get; set; }

  /// <summary>
  /// The user info endpoint of the external provider.
  /// </summary>
  public Optional<string?> UserInfoUrl { get; set; }

  /// <summary>
  /// The PKCE mode used with the external provider.
  /// </summary>
  public Optional<OidcPkceMode> PkceMode { get; set; }
}


