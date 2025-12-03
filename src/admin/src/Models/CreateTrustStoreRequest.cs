namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// Create Trust Store Request.
/// </summary>
public class CreateTrustStoreRequest
{
  /// <summary>
  /// Name of the trust store
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Specifies if the specific trust store metadata should be shown in the discovery endpoint.
  /// </summary>
  public bool? ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// The entire certificate chain
  /// </summary>
  public string CertChain { get; set; }

  /// <summary>
  /// The Trust store options
  /// </summary>
  public CreateTrustStoreOptionsRequest Options { get; set; }
}


