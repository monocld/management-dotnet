namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Log Target response
/// </summary>
public class LogTarget
{
  /// <summary>
  /// The target type
  /// </summary>
  public TargetTypes Type { get; set; }

  /// <summary>
  /// The target id
  /// </summary>
  public string? Id { get; set; }
}


