namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Log Request response
/// </summary>
public class LogRequest
{
  /// <summary>
  /// The trace identifier of the request
  /// </summary>
  public string? TraceId { get; set; }

  /// <summary>
  /// The user agent of the request.
  /// </summary>
  public string? UserAgent { get; set; }

  /// <summary>
  /// The remote ip address of the request
  /// </summary>
  public LogIpDetails? RemoteIp { get; set; }

  /// <summary>
  /// The location details from which the request was made
  /// </summary>
  public LogLocation? Location { get; set; }
}


