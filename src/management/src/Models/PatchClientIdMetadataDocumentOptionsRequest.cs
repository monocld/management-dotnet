namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Client ID Metadata Document Options Request: Used to update tenant-wide CIMD configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchClientIdMetadataDocumentOptionsRequest>))]
public class PatchClientIdMetadataDocumentOptionsRequest
{
  /// <summary>
  /// Specifies whether Client ID Metadata Documents (CIMD) are enabled for the tenant.
  /// </summary>
  public Optional<bool> EnableClientIdMetadataDocuments { get; set; }

  /// <summary>
  /// When &#x60;true&#x60;, any well-formed HTTPS client_id URL is accepted (subject to SSRF protection).
  /// </summary>
  public Optional<bool> AllowAnyClientIdHost { get; set; }

  /// <summary>
  /// The allow-list of client_id hosts permitted as CIMD identifiers (supports a leading wildcard label).
  /// </summary>
  public Optional<List<string>> TrustedClientIdHosts { get; set; }

  /// <summary>
  /// When &#x60;true&#x60;, every URL in the metadata document must share the client_id host.
  /// </summary>
  public Optional<bool> RequireSameOrigin { get; set; }

  /// <summary>
  /// The maximum size, in bytes, of a fetched metadata document.
  /// </summary>
  public Optional<int> MaxDocumentSizeBytes { get; set; }

  /// <summary>
  /// The HTTP timeout, in seconds, when fetching a metadata document.
  /// </summary>
  public Optional<int> HttpTimeoutSeconds { get; set; }

  /// <summary>
  /// The minimum cache TTL, in seconds, for a fetched metadata document.
  /// </summary>
  public Optional<int> MinCacheTtlSeconds { get; set; }

  /// <summary>
  /// The default cache TTL, in seconds, applied when the response has no usable HTTP cache headers.
  /// </summary>
  public Optional<int> DefaultCacheTtlSeconds { get; set; }

  /// <summary>
  /// The maximum cache TTL, in seconds, for a fetched metadata document.
  /// </summary>
  public Optional<int> MaxCacheTtlSeconds { get; set; }

  /// <summary>
  /// When &#x60;true&#x60;, consent is always shown for CIMD clients (anti-phishing).
  /// </summary>
  public Optional<bool> ForceConsent { get; set; }

  /// <summary>
  /// When &#x60;true&#x60;, the metadata document is fetched and re-validated on every flow, bypassing the cache.
  /// </summary>
  public Optional<bool> AlwaysRefetch { get; set; }
}


