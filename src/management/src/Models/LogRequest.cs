namespace MonoCloud.Management.Models;

/// <summary>
/// Log Request Response: Represents request-level metadata associated with the log entry.
/// </summary>
public class LogRequest
{
  /// <summary>
  /// The trace identifier of the request.
  /// </summary>
  public string? TraceId { get; set; }

  /// <summary>
  /// The user agent associated with the request.
  /// </summary>
  public string? UserAgent { get; set; }

  /// <summary>
  /// The remote IP address of the request.
  /// </summary>
  public LogIpDetails? RemoteIp { get; set; }

  /// <summary>
  /// The geographical location from which the request was made.
  /// </summary>
  public LogLocation? Location { get; set; }

  /// <summary>
  /// Specifies whether the request was a mTLS request.
  /// </summary>
  public bool IsMtls { get; set; }

  /// <summary>
  /// Specifies whether the request was authenticated with a SPIFFE SVID.
  /// </summary>
  public bool IsSpiffe { get; set; }

  /// <summary>
  /// The id of the trust store used to authenticate the request.
  /// </summary>
  public string? TrustStoreId { get; set; }

  /// <summary>
  /// The subject of the client certificate used in the request.
  /// </summary>
  public string? CertificateSubject { get; set; }

  /// <summary>
  /// The issuer of the client certificate used in the request.
  /// </summary>
  public string? CertificateIssuer { get; set; }

  /// <summary>
  /// The SAN URIs of the client certificate used in the request.
  /// </summary>
  public List<string>? SanUris { get; set; }

  /// <summary>
  /// The SPIFFE ID of the SVID (X.509-SVID or JWT-SVID) that authenticated the request.
  /// </summary>
  public string? SpiffeId { get; set; }
}


