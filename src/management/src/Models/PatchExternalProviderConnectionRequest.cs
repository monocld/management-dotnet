namespace MonoCloud.Management.Models;

/// <summary>
/// Patch External Provider Connection Request: Used to update connection settings used by an external authenticator.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchExternalProviderConnectionRequest>))]
public class PatchExternalProviderConnectionRequest
{
  /// <summary>
  /// The discovery (metadata) endpoint of the external provider. The provider endpoints are derived from the discovery document.
  /// </summary>
  public Optional<string> DiscoveryUrl { get; set; }

  /// <summary>
  /// The PKCE mode used with the external provider.
  /// </summary>
  public Optional<OidcPkceMode> PkceMode { get; set; }
}


