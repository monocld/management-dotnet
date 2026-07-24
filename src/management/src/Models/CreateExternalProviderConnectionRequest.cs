namespace MonoCloud.Management.Models;

/// <summary>
/// Create External Provider Connection Request: The protocol connection settings used to communicate with the external identity provider.
/// </summary>
public class CreateExternalProviderConnectionRequest
{
  /// <summary>
  /// The discovery (metadata) endpoint of the external provider. The provider endpoints are derived from the discovery document.
  /// </summary>
  public string DiscoveryUrl { get; set; }

  /// <summary>
  /// The PKCE mode used with the external provider.
  /// </summary>
  public OidcPkceMode? PkceMode { get; set; }
}


