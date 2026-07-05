namespace MonoCloud.Management.Models;

/// <summary>
/// Client ID Metadata Document Options Response: Represents the tenant-wide CIMD configuration.
/// </summary>
public class ClientIdMetadataDocumentOptions
{
  /// <summary>
  /// Specifies whether Client ID Metadata Documents (CIMD) are enabled for the tenant.
  /// </summary>
  public bool EnableClientIdMetadataDocuments { get; set; }

  /// <summary>
  /// When &#x60;true&#x60;, any well-formed HTTPS client_id URL is accepted (subject to SSRF protection). When &#x60;false&#x60;, only hosts in the trusted client_id host allow-list are accepted.
  /// </summary>
  public bool AllowAnyClientIdHost { get; set; }

  /// <summary>
  /// The allow-list of client_id hosts permitted as CIMD identifiers. Supports a leading wildcard label (e.g. &#x60;*.example.com&#x60;). Ignored when any client_id host is allowed.
  /// </summary>
  public List<string> TrustedClientIdHosts { get; set; }

  /// <summary>
  /// When &#x60;true&#x60;, every URL in the metadata document (redirect_uris, client_uri, logo_uri) must share the client_id host.
  /// </summary>
  public bool RequireSameOrigin { get; set; }

  /// <summary>
  /// The maximum size, in bytes, of a fetched metadata document.
  /// </summary>
  public int MaxDocumentSizeBytes { get; set; }

  /// <summary>
  /// The HTTP timeout, in seconds, when fetching a metadata document.
  /// </summary>
  public int HttpTimeoutSeconds { get; set; }

  /// <summary>
  /// The minimum cache TTL, in seconds, for a fetched metadata document, regardless of HTTP cache headers.
  /// </summary>
  public int MinCacheTtlSeconds { get; set; }

  /// <summary>
  /// The default cache TTL, in seconds, applied when the response has no usable HTTP cache headers.
  /// </summary>
  public int DefaultCacheTtlSeconds { get; set; }

  /// <summary>
  /// The maximum cache TTL, in seconds, for a fetched metadata document, regardless of HTTP cache headers.
  /// </summary>
  public int MaxCacheTtlSeconds { get; set; }

  /// <summary>
  /// When &#x60;true&#x60;, consent is always shown for CIMD clients (anti-phishing), regardless of remembered consent.
  /// </summary>
  public bool ForceConsent { get; set; }

  /// <summary>
  /// When &#x60;true&#x60;, the metadata document is fetched and re-validated on every flow, bypassing the cache.
  /// </summary>
  public bool AlwaysRefetch { get; set; }
}


