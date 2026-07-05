namespace MonoCloud.Management.Models;

/// <summary>
/// The authentication profile used to connect to a SPIFFE bundle endpoint.
/// </summary>
public enum BundleEndpointProfile
{
  /// <summary>
  /// The bundle endpoint is served over TLS using a Web PKI (publicly trusted) certificate, validated against the system trust store and the endpoint host name.
  /// </summary>
  HttpsWeb,

  /// <summary>
  /// The bundle endpoint is served over TLS using a SPIFFE X.509-SVID, validated against the configured endpoint SPIFFE ID and the trust domain's bundle (bootstrapped from an operator-supplied bundle).
  /// </summary>
  HttpsSpiffe
}


