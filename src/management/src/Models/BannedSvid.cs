namespace MonoCloud.Management.Models;

/// <summary>
/// Banned SVID Response: Represents a SVID that has been explicitly banned within a trust store.
/// </summary>
public class BannedSvid
{
  /// <summary>
  /// The unique identifier of the banned SVID entry.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// The identifier value used for banning.
  /// </summary>
  public string Value { get; set; }

  /// <summary>
  /// The reason explaining why the SVID was banned.
  /// </summary>
  public string? Reason { get; set; }

  /// <summary>
  /// Specifies the time at which the SVID was banned (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }
}


