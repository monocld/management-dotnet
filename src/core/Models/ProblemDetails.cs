namespace MonoCloud.Management.Core.Models;

/// <summary>
/// The Problem Details
/// </summary>
public class ProblemDetails
{
  /// <summary>
  /// The type of error
  /// </summary>
  public string Type { get; set; } = string.Empty;

  /// <summary>
  /// The title of the error
  /// </summary>
  public string Title { get; set; } = string.Empty;

  /// <summary>
  /// The status code representing the error
  /// </summary>
  public int Status { get; set; }

  /// <summary>
  /// The error details
  /// </summary>
  public string Detail { get; set; } = string.Empty;

  /// <summary>
  /// The instance
  /// </summary>
  public string Instance { get; set; } = string.Empty;

  /// <summary>
  /// The machine-readable code identifying the error. Null when the operation reported this status without one.
  /// </summary>
  public string? ErrorCode { get; set; }

  /// <summary>
  /// The identifier of the request, for tracing and diagnostics
  /// </summary>
  public string TraceId { get; set; } = string.Empty;

  /// <summary>
  /// Additional data about the error
  /// </summary>
  [JsonExtensionData]
  public IDictionary<string, object> ExtensionData { get; set; } = new Dictionary<string, object>();
}
