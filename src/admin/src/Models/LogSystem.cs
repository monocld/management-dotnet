namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Log System response
/// </summary>
public class LogSystem
{
  /// <summary>
  /// The activity id
  /// </summary>
  public string? ActivityId { get; set; }

  /// <summary>
  /// The process id
  /// </summary>
  public int ProcessId { get; set; }

  /// <summary>
  /// The local ip address details
  /// </summary>
  public LogIpDetails LocalIp { get; set; }
}


